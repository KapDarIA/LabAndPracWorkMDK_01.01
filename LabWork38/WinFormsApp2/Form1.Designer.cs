namespace WinFormsApp2
{
    partial class Task1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            nextButton = new Button();
            label = new Label();
            numericUpDown = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.MintCream;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 27);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(776, 329);
            dataGridView.TabIndex = 0;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.LightSteelBlue;
            nextButton.Location = new Point(638, 368);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(150, 23);
            nextButton.TabIndex = 1;
            nextButton.Text = "Показать ещё";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += NextButton_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Azure;
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(156, 15);
            label.TabIndex = 3;
            label.Text = "Показано {x} из {y} записей";
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(129, 369);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(39, 23);
            numericUpDown.TabIndex = 4;
            numericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Location = new Point(12, 371);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 5;
            label1.Text = "Размер страницы";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 403);
            Controls.Add(label1);
            Controls.Add(numericUpDown);
            Controls.Add(label);
            Controls.Add(nextButton);
            Controls.Add(dataGridView);
            Name = "Task1";
            Text = "Task1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button nextButton;
        private Label label;
        private NumericUpDown numericUpDown;
        private Label label1;
    }
}
