namespace Task1
{
    public partial class Form1 : Form
    {
        FileInfo loginFile = new FileInfo("logins.csv");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click_Click(object sender, EventArgs e)
        {
            if (!loginFile.Exists)
            {
                errorLabel.Text = ("Файл не существет");
                return;
            }
            var loginRows = File.ReadAllLines(loginFile.FullName);
            foreach (var loginRow in loginRows)
            {
                string[] login = loginRow.Split(';');
                if (loginTextBox.Text == login[0])
                {
                    errorLabel.Text = ("Такой логин уже есть");
                    return;
                }
            }
            File.AppendAllText(loginFile.FullName, 
                $"{loginTextBox.Text};{passwordTextBox.Text};{DateTime.Now}{Environment.NewLine}");
            MessageBox.Show("Регистрация прошла успешно");
            errorLabel.Text = "Ошибок нет";
        }
    }
}
