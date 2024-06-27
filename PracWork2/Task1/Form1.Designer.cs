namespace Task1
{
    partial class Form1
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
            errorLabel = new Label();
            LoginLabel = new Label();
            loginTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            RegistrationButton_Click = new Button();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(12, 9);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 0;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(12, 24);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(86, 15);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Введите логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(12, 42);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(169, 23);
            loginTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 68);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Введите пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 86);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(169, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // RegistrationButton_Click
            // 
            RegistrationButton_Click.Location = new Point(12, 115);
            RegistrationButton_Click.Name = "RegistrationButton_Click";
            RegistrationButton_Click.Size = new Size(169, 23);
            RegistrationButton_Click.TabIndex = 5;
            RegistrationButton_Click.Text = "Зарегистрироваться";
            RegistrationButton_Click.UseVisualStyleBackColor = true;
            RegistrationButton_Click.Click += RegistrationButton_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 188);
            Controls.Add(RegistrationButton_Click);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(errorLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
        private Label LoginLabel;
        private TextBox loginTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button RegistrationButton_Click;
    }
}
