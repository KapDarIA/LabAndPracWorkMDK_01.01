namespace Task3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            changeButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // changeButton
            // 
            changeButton.Location = new Point(12, 210);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(115, 23);
            changeButton.TabIndex = 0;
            changeButton.Text = "Замена";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 192);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 244);
            Controls.Add(textBox1);
            Controls.Add(changeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button changeButton;
        private TextBox textBox1;
    }
}