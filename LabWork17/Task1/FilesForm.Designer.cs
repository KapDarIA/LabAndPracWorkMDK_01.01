namespace Task1
{
    partial class FilesForm
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
            filesDataGridView = new DataGridView();
            task1Button = new Button();
            task2Button = new Button();
            changeButton = new Button();
            task3Button = new Button();
            task4Button = new Button();
            task5Button = new Button();
            userTextBox = new TextBox();
            label1 = new Label();
            directoryTextBox = new TextBox();
            task6Button = new Button();
            task7Button = new Button();
            task8Button = new Button();
            ((System.ComponentModel.ISupportInitialize)filesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // filesDataGridView
            // 
            filesDataGridView.AllowUserToOrderColumns = true;
            filesDataGridView.BackgroundColor = Color.White;
            filesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filesDataGridView.Location = new Point(12, 41);
            filesDataGridView.Name = "filesDataGridView";
            filesDataGridView.Size = new Size(662, 397);
            filesDataGridView.TabIndex = 0;
            // 
            // task1Button
            // 
            task1Button.Location = new Point(680, 12);
            task1Button.Name = "task1Button";
            task1Button.Size = new Size(162, 23);
            task1Button.TabIndex = 1;
            task1Button.Text = "Задание 1";
            task1Button.UseVisualStyleBackColor = true;
            task1Button.Click += Task1Button_Click;
            // 
            // task2Button
            // 
            task2Button.Location = new Point(680, 41);
            task2Button.Name = "task2Button";
            task2Button.Size = new Size(162, 23);
            task2Button.TabIndex = 2;
            task2Button.Text = "Задание 2";
            task2Button.UseVisualStyleBackColor = true;
            task2Button.Click += Task2Button_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(680, 393);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(162, 45);
            changeButton.TabIndex = 3;
            changeButton.Text = "Вернуть исходную таблицу";
            changeButton.UseVisualStyleBackColor = true;
            // 
            // task3Button
            // 
            task3Button.Location = new Point(680, 70);
            task3Button.Name = "task3Button";
            task3Button.Size = new Size(162, 23);
            task3Button.TabIndex = 4;
            task3Button.Text = "Задание 3";
            task3Button.UseVisualStyleBackColor = true;
            task3Button.Click += Task3Button_Click;
            // 
            // task4Button
            // 
            task4Button.Location = new Point(680, 99);
            task4Button.Name = "task4Button";
            task4Button.Size = new Size(162, 23);
            task4Button.TabIndex = 5;
            task4Button.Text = "Задание 4";
            task4Button.UseVisualStyleBackColor = true;
            task4Button.Click += task4Button_Click;
            // 
            // task5Button
            // 
            task5Button.Location = new Point(680, 172);
            task5Button.Name = "task5Button";
            task5Button.Size = new Size(162, 23);
            task5Button.TabIndex = 6;
            task5Button.Text = "Задание 5";
            task5Button.UseVisualStyleBackColor = true;
            task5Button.Click += task5Button_Click;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(680, 143);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(162, 23);
            userTextBox.TabIndex = 7;
            userTextBox.Text = "LabWork\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(680, 125);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 8;
            label1.Text = "Введите текст для задания два";
            // 
            // directoryTextBox
            // 
            directoryTextBox.Location = new Point(12, 12);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.Size = new Size(662, 23);
            directoryTextBox.TabIndex = 9;
            directoryTextBox.Text = "C:\\temp\\ispp21\\МДК 01.01\\LabWorks";
            // 
            // task6Button
            // 
            task6Button.Location = new Point(680, 201);
            task6Button.Name = "task6Button";
            task6Button.Size = new Size(162, 23);
            task6Button.TabIndex = 10;
            task6Button.Text = "Задание 6";
            task6Button.UseVisualStyleBackColor = true;
            task6Button.Click += task6Button_Click;
            // 
            // task7Button
            // 
            task7Button.Location = new Point(680, 230);
            task7Button.Name = "task7Button";
            task7Button.Size = new Size(162, 23);
            task7Button.TabIndex = 11;
            task7Button.Text = "Задание 7";
            task7Button.UseVisualStyleBackColor = true;
            // 
            // task8Button
            // 
            task8Button.Location = new Point(680, 259);
            task8Button.Name = "task8Button";
            task8Button.Size = new Size(162, 23);
            task8Button.TabIndex = 12;
            task8Button.Text = "Задание 8";
            task8Button.UseVisualStyleBackColor = true;
            // 
            // FilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            Controls.Add(task8Button);
            Controls.Add(task7Button);
            Controls.Add(task6Button);
            Controls.Add(directoryTextBox);
            Controls.Add(label1);
            Controls.Add(userTextBox);
            Controls.Add(task5Button);
            Controls.Add(task4Button);
            Controls.Add(task3Button);
            Controls.Add(changeButton);
            Controls.Add(task2Button);
            Controls.Add(task1Button);
            Controls.Add(filesDataGridView);
            Name = "FilesForm";
            Text = "FilesForm";
            ((System.ComponentModel.ISupportInitialize)filesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView filesDataGridView;
        private Button task1Button;
        private Button task2Button;
        private Button changeButton;
        private Button task3Button;
        private Button task4Button;
        private Button task5Button;
        private TextBox userTextBox;
        private Label label1;
        private TextBox directoryTextBox;
        private Button task6Button;
        private Button task7Button;
        private Button task8Button;
    }
}
