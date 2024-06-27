using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Task123
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "Text File|*.txt|Sourse Code File|*.cs|HTML File|*.html|Cascading Style Sheets|*.css|Java Script File|*.js|MySQL File|*.sql",
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Открытие файла"
            };

            if (dialog.ShowDialog() != true)
                return;

            FileTextBox.Text = File.ReadAllText(dialog.FileName);
            Title = dialog.SafeFileName;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "Text File|*.txt|Sourse Code File|*.cs|HTML File|*.html|Cascading Style Sheets|*.css|Java Script File|*.js|MySQL File|*.sql",
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Сохранение файла"
            };

            if (dialog.ShowDialog() != true)
                return;

            File.WriteAllText(dialog.FileName, FileTextBox.Text);
            MessageBox.Show("Файл успешно сохранен");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть приложение?",
                "Подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                e.Cancel = true;
        }
    }
}