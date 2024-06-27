namespace Task1
{
    partial class WordForm
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
            templateButton = new Button();
            infoTextBox = new TextBox();
            textLabel = new Label();
            taskLabel = new Label();
            rowsTextBox = new TextBox();
            SuspendLayout();
            // 
            // templateButton
            // 
            templateButton.Location = new Point(351, 227);
            templateButton.Name = "templateButton";
            templateButton.Size = new Size(198, 23);
            templateButton.TabIndex = 0;
            templateButton.Text = "Создать документ по шаблону";
            templateButton.UseVisualStyleBackColor = true;
            templateButton.Click += TemplateButton_Click;
            // 
            // infoTextBox
            // 
            infoTextBox.Location = new Point(12, 27);
            infoTextBox.Multiline = true;
            infoTextBox.Name = "infoTextBox";
            infoTextBox.Size = new Size(537, 155);
            infoTextBox.TabIndex = 2;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(12, 9);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(81, 15);
            textLabel.TabIndex = 3;
            textLabel.Text = "Введите текст";
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new Point(12, 185);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(162, 15);
            taskLabel.TabIndex = 4;
            taskLabel.Text = "Выберите количество строк";
            // 
            // rowsTextBox
            // 
            rowsTextBox.Location = new Point(12, 203);
            rowsTextBox.Name = "rowsTextBox";
            rowsTextBox.Size = new Size(162, 23);
            rowsTextBox.TabIndex = 5;
            // 
            // WordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 262);
            Controls.Add(rowsTextBox);
            Controls.Add(taskLabel);
            Controls.Add(textLabel);
            Controls.Add(infoTextBox);
            Controls.Add(templateButton);
            Name = "WordForm";
            Text = "WordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button templateButton;
        private TextBox infoTextBox;
        private Label textLabel;
        private Label taskLabel;
        private TextBox rowsTextBox;
    }
}
