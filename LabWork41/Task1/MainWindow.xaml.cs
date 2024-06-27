using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuStackPanel.Width > 30)
            {
                DoubleAnimation menuAnimation = new DoubleAnimation();
                menuAnimation.From = MenuStackPanel.ActualWidth;
                menuAnimation.To = 26;
                menuAnimation.Duration = TimeSpan.FromSeconds(1);
                MenuStackPanel.BeginAnimation(StackPanel.WidthProperty, menuAnimation);
            }
            else
            {
                DoubleAnimation menuAnimation = new DoubleAnimation();
                menuAnimation.From = MenuStackPanel.ActualWidth;
                menuAnimation.To = 100;
                menuAnimation.Duration = TimeSpan.FromSeconds(1);
                MenuStackPanel.BeginAnimation(StackPanel.WidthProperty, menuAnimation);
            }
        }
    }
}
