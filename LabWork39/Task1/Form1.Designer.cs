namespace Task1
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.task1Button = new System.Windows.Forms.Button();
            this.task2Button = new System.Windows.Forms.Button();
            this.task3Button = new System.Windows.Forms.Button();
            this.task4Button = new System.Windows.Forms.Button();
            this.task5Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 380);
            this.dataGridView.TabIndex = 0;
            // 
            // task1Button
            // 
            this.task1Button.BackColor = System.Drawing.Color.LightGreen;
            this.task1Button.Location = new System.Drawing.Point(13, 415);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(75, 23);
            this.task1Button.TabIndex = 1;
            this.task1Button.Text = "task1";
            this.task1Button.UseVisualStyleBackColor = false;
            this.task1Button.Click += new System.EventHandler(this.task1Button_Click);
            // 
            // task2Button
            // 
            this.task2Button.BackColor = System.Drawing.Color.LightGreen;
            this.task2Button.Location = new System.Drawing.Point(94, 415);
            this.task2Button.Name = "task2Button";
            this.task2Button.Size = new System.Drawing.Size(75, 23);
            this.task2Button.TabIndex = 2;
            this.task2Button.Text = "task2";
            this.task2Button.UseVisualStyleBackColor = false;
            this.task2Button.Click += new System.EventHandler(this.task2Button_Click);
            // 
            // task3Button
            // 
            this.task3Button.BackColor = System.Drawing.Color.LightGreen;
            this.task3Button.Location = new System.Drawing.Point(175, 415);
            this.task3Button.Name = "task3Button";
            this.task3Button.Size = new System.Drawing.Size(75, 23);
            this.task3Button.TabIndex = 3;
            this.task3Button.Text = "task3";
            this.task3Button.UseVisualStyleBackColor = false;
            this.task3Button.Click += new System.EventHandler(this.task3Button_Click);
            // 
            // task4Button
            // 
            this.task4Button.BackColor = System.Drawing.Color.LightGreen;
            this.task4Button.Location = new System.Drawing.Point(256, 415);
            this.task4Button.Name = "task4Button";
            this.task4Button.Size = new System.Drawing.Size(75, 23);
            this.task4Button.TabIndex = 4;
            this.task4Button.Text = "task4";
            this.task4Button.UseVisualStyleBackColor = false;
            this.task4Button.Click += new System.EventHandler(this.task4Button_Click);
            // 
            // task5Button
            // 
            this.task5Button.BackColor = System.Drawing.Color.LightGreen;
            this.task5Button.Location = new System.Drawing.Point(337, 415);
            this.task5Button.Name = "task5Button";
            this.task5Button.Size = new System.Drawing.Size(75, 23);
            this.task5Button.TabIndex = 5;
            this.task5Button.Text = "task5";
            this.task5Button.UseVisualStyleBackColor = false;
            this.task5Button.Click += new System.EventHandler(this.task5Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.task5Button);
            this.Controls.Add(this.task4Button);
            this.Controls.Add(this.task3Button);
            this.Controls.Add(this.task2Button);
            this.Controls.Add(this.task1Button);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button task1Button;
        private System.Windows.Forms.Button task2Button;
        private System.Windows.Forms.Button task3Button;
        private System.Windows.Forms.Button task4Button;
        private System.Windows.Forms.Button task5Button;
    }
}

