using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LabWork28.Windows
{
    /// <summary>
    /// Логика взаимодействия для ControlWindow.xaml
    /// </summary>
    public partial class ControlWindow : Window
    {
        public ControlWindow()
        {
            InitializeComponent();
        }

        private void LightButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeTheme("LightTheme");
        }
        private void DarkButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeTheme("DarkTheme");
        }
        private void ChangeTheme(string themeName)
        {
            var uriDict = new Uri($"Themes/{themeName}.xaml", UriKind.Relative);
            ResourceDictionary dictionary = Application.LoadComponent(uriDict) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }


    }
}
