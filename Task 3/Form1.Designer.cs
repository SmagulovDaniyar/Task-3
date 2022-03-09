namespace Task_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.labelProcessor1 = new System.Windows.Forms.Label();
            this.labelProcessor2 = new System.Windows.Forms.Label();
            this.labelDenied = new System.Windows.Forms.Label();
            this.dataGridViewProcessor1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewProcessor2 = new System.Windows.Forms.DataGridView();
            this.updater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessor2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(758, 74);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // labelProcessor1
            // 
            this.labelProcessor1.AutoSize = true;
            this.labelProcessor1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessor1.Location = new System.Drawing.Point(56, 93);
            this.labelProcessor1.Name = "labelProcessor1";
            this.labelProcessor1.Size = new System.Drawing.Size(168, 27);
            this.labelProcessor1.TabIndex = 1;
            this.labelProcessor1.Text = "Processor1: ";
            // 
            // labelProcessor2
            // 
            this.labelProcessor2.AutoSize = true;
            this.labelProcessor2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessor2.Location = new System.Drawing.Point(580, 93);
            this.labelProcessor2.Name = "labelProcessor2";
            this.labelProcessor2.Size = new System.Drawing.Size(168, 27);
            this.labelProcessor2.TabIndex = 2;
            this.labelProcessor2.Text = "Processor2: ";
            // 
            // labelDenied
            // 
            this.labelDenied.AutoSize = true;
            this.labelDenied.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDenied.Location = new System.Drawing.Point(336, 93);
            this.labelDenied.Name = "labelDenied";
            this.labelDenied.Size = new System.Drawing.Size(116, 27);
            this.labelDenied.TabIndex = 3;
            this.labelDenied.Text = "Denied: ";
            // 
            // dataGridViewProcessor1
            // 
            this.dataGridViewProcessor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessor1.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewProcessor1.Name = "dataGridViewProcessor1";
            this.dataGridViewProcessor1.RowHeadersWidth = 51;
            this.dataGridViewProcessor1.RowTemplate.Height = 24;
            this.dataGridViewProcessor1.Size = new System.Drawing.Size(370, 74);
            this.dataGridViewProcessor1.TabIndex = 4;
            // 
            // dataGridViewProcessor2
            // 
            this.dataGridViewProcessor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessor2.Location = new System.Drawing.Point(400, 134);
            this.dataGridViewProcessor2.Name = "dataGridViewProcessor2";
            this.dataGridViewProcessor2.RowHeadersWidth = 51;
            this.dataGridViewProcessor2.RowTemplate.Height = 24;
            this.dataGridViewProcessor2.Size = new System.Drawing.Size(370, 74);
            this.dataGridViewProcessor2.TabIndex = 5;
            // 
            // updater
            // 
            this.updater.Interval = 1;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(782, 219);
            this.Controls.Add(this.dataGridViewProcessor2);
            this.Controls.Add(this.dataGridViewProcessor1);
            this.Controls.Add(this.labelDenied);
            this.Controls.Add(this.labelProcessor2);
            this.Controls.Add(this.labelProcessor1);
            this.Controls.Add(this.dataGridViewCustomers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Label labelProcessor1;
        private System.Windows.Forms.Label labelProcessor2;
        private System.Windows.Forms.Label labelDenied;
        private System.Windows.Forms.DataGridView dataGridViewProcessor1;
        private System.Windows.Forms.DataGridView dataGridViewProcessor2;
        private System.Windows.Forms.Timer updater;
    }
}

