using System.Windows;
using System.Windows.Controls;

namespace LabWork31
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DatePicker.DisplayDateEnd = DateTime.Now;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text != "" && PasswordBox.Password == CorrectPasswordBox.Password && PasswordBox.Password != "")
                MessageBox.Show($"{LoginTextBox}, вы успешно зарегистрировались!", "Сообщение");
            else 
                MessageBox.Show("Пароли не совпадают или некорректный логин", "Внимание!");
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var dateTime = DateTime.Now.Year - DatePicker.SelectedDate.Value.Year;
            DateLabel.Content = $"Вам лет:{dateTime}";
        }

        private void PriceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var price = Math.Round(PriceSlider.Value, 2);
            PriceLabel.Content = price.ToString();

            ResultMethod();
        }

        private void PercentSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var percent = Math.Round(PercentSlider.Value, 2);
            PercentLabel.Content = percent.ToString();

            ResultMethod();
        }

        private void ResultMethod()
        {
            if (PriceSlider.Value > 0 && PercentSlider.Value > 0)
            {
                var price = Math.Round(PriceSlider.Value, 2);
                var percent = Math.Round(PercentSlider.Value, 2);
                var result = (price / 100) * percent;
                ResultLabel.Content = $"Результат: {Math.Round(result, 2)}";
            }
            else 
                ResultLabel.Content = $"Результат: {0}";
        }
    }
}