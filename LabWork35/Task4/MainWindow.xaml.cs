using Microsoft.Win32;
using System.Windows;

namespace Task4
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
                Filter = "Картинки|*.png;*.jpg;*.jpeg;*.bmp",
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Выбор изображений",
                Multiselect = true
            };

            if (dialog.ShowDialog() != true)
                return;
            ImagesListView.ItemsSource = dialog.FileNames;
        }
    }
}