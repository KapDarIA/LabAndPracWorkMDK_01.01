using System.Windows;
using System.Windows.Controls;

namespace LabWork34
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateStatusBarItem.Content = DateTime.Now;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SignCounterStatusBarItem.Content = $"Количество символов: {TextBox.Text.Length}";
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if(StatusBar != null) 
            StatusBar.Visibility= Visibility.Visible;
        }

        private void StatusMenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ScaleStatusBarItem != null)
                ScaleStatusBarItem.Content = $"Масштаб: {Math.Round(ScaleSlider.Value, 0)}%";
        }

        private void ClearMenuItem_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Clear();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }
    }
}