using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LabWork30
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte red;
        byte green;
        byte blue;
        public MainWindow()
        {
            InitializeComponent();
            AgreeButton.IsEnabled = false;
            ChangeColor();
        }

        private void AgreeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            AgreeButton.IsEnabled = true;
        }

        private void AgreeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            AgreeButton.IsEnabled = false;
        }

        private void PasswordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            AuthorizationPasswordBox.Visibility = Visibility.Collapsed;
            PasswordTextBox.Text = AuthorizationPasswordBox.Password;
            PasswordTextBox.Visibility = Visibility.Visible;
        }

        private void PasswordCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Visibility = Visibility.Collapsed;
            AuthorizationPasswordBox.Password = PasswordTextBox.Text;
            AuthorizationPasswordBox.Visibility = Visibility.Visible;
        }

        private void SizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.FontSize = Convert.ToInt32((sender as RadioButton).Content);
        }

        private void LeftAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Left;
        }

        private void CenterAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Center;
        }

        private void RightAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Right;
        }

        private void ColorCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ChangeColor();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void ChangeColor()
        {
            red = RedColorCheckBox.IsChecked == true ? (byte)RedColorSlider.Value : (byte)0;
            green = GreenColorCheckBox.IsChecked == true ? (byte)GreenColorSlider.Value : (byte)0;
            blue = BlueColorCheckBox.IsChecked == true ? (byte)BlueColorSlider.Value : (byte)0;

            Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
    }
}