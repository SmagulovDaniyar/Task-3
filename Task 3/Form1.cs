using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class MainForm : Form
    {
        private static object _locker = new object();

        Queue<int> queue = new Queue<int>();
        int customers;
        int amount1;
        int amount2;
        int denies;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; ++i)
            {
                dataGridViewCustomers.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                dataGridViewCustomers.Columns[i - 1].Width = 20;
            }
                

            for (int i = 1; i <= 100; ++i)
            {
                dataGridViewProcessor1.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                dataGridViewProcessor1.Columns[i - 1].Width = 20;
            }
                

            for (int i = 1; i <= 100; ++i)
            {
                dataGridViewProcessor2.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                dataGridViewProcessor2.Columns[i - 1].Width = 20;
            }
                


            System.Threading.Thread queueGenerator = new System.Threading.Thread(QueueGenerator);
            System.Threading.Thread processor1 = new System.Threading.Thread(Processor1);
            System.Threading.Thread processor2 = new System.Threading.Thread(Processor2);

            queueGenerator.Start();
            processor1.Start();
            processor2.Start();

            updater.Start();
        }

        private void QueueGenerator()
        {
            int queueSize = 10;

            Random random = new Random();

            for (customers = 1; customers <= 100; ++customers)
            {
                int temp = random.Next(1, 100);

                dataGridViewCustomers.Rows[0].Cells[customers - 1].Value = temp;

                if (queue.Count != 10)
                {
                    queue.Enqueue(temp);
                    dataGridViewCustomers.Rows[0].Cells[customers - 1].Style.BackColor = Color.Green;
                }
                else
                {
                    denies++;
                    dataGridViewCustomers.Rows[0].Cells[customers - 1].Style.BackColor = Color.Red;
                }
                    
                System.Threading.Thread.Sleep(1000);
            }

            customers--;
        }

        private void Processor1()
        {
            Queue<int> priorityQueue = new Queue<int>();
            Queue<int> ordinaryQueue = new Queue<int>();

            while (true)
            {
                System.Threading.Thread.Sleep(2000);

                lock (_locker)
                {
                    if (queue.Count != 0)
                    {
                        if (queue.Peek() % 2 == 0)
                        {
                            priorityQueue.Enqueue(queue.Peek());
                            queue.Dequeue();
                        }
                        else
                        {
                            ordinaryQueue.Enqueue(queue.Peek());
                            queue.Dequeue();
                        }
                    }
                }
                
                    
                if (priorityQueue.Count != 0)
                {
                    dataGridViewProcessor1.Rows[0].Cells[amount1].Value = priorityQueue.Peek();
                    dataGridViewProcessor1.Rows[0].Cells[amount1].Style.BackColor = Color.Yellow;
                    priorityQueue.Dequeue();
                    amount1++;
                    continue;
                }

                if (ordinaryQueue.Count != 0)
                {
                    dataGridViewProcessor1.Rows[0].Cells[amount1].Value = ordinaryQueue.Peek();
                    dataGridViewProcessor1.Rows[0].Cells[amount1].Style.BackColor = Color.Brown;
                    ordinaryQueue.Dequeue();
                    amount1++;
                    continue;
                }

                if (queue.Count == 0 &&
                    customers == 100)
                {
                    //labelProcessor1.Text = "Processor1: " + Convert.ToString(amount);
                    break;
                }
            }
        }

        private void Processor2()
        {
            Queue<int> priorityQueue = new Queue<int>();
            Queue<int> ordinaryQueue = new Queue<int>();

            while (true)
            {
                System.Threading.Thread.Sleep(2000);

                lock (_locker)
                {
                    if (queue.Count != 0 &&
                    queue.Peek() % 2 == 0)
                    {
                        if (queue.Peek() % 4 == 0)
                        {
                            priorityQueue.Enqueue(queue.Count);
                            queue.Dequeue();
                        }
                        else
                        {
                            ordinaryQueue.Enqueue(queue.Count);
                            queue.Dequeue();
                        }
                    }
                }

                if (priorityQueue.Count != 0)
                {
                    dataGridViewProcessor2.Rows[0].Cells[amount2].Value = priorityQueue.Peek();
                    dataGridViewProcessor2.Rows[0].Cells[amount2].Style.BackColor = Color.Yellow;
                    priorityQueue.Dequeue();
                    amount2++;     
                    continue;
                }

                if (ordinaryQueue.Count != 0)
                {
                    dataGridViewProcessor2.Rows[0].Cells[amount2].Value = ordinaryQueue.Peek();
                    dataGridViewProcessor2.Rows[0].Cells[amount2].Style.BackColor = Color.Brown;
                    ordinaryQueue.Dequeue();
                    amount2++;
                    continue;
                }

                if (queue.Count == 0 &&
                    customers == 100)
                {
                    //labelProcessor2.Text = "Processor2: " + Convert.ToString(amount);
                    break;
                }                   
            }
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            labelProcessor1.Text = "Processor1: " + Convert.ToString(amount1);
            labelProcessor2.Text = "Processor1: " + Convert.ToString(amount2);
            labelDenied.Text = "Denied: " + Convert.ToString(denies);
        }
    }
}