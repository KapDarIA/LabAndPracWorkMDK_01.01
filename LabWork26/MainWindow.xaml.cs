﻿using System.Windows;

namespace LabWork26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new();
            window1.Show();
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new();
            window3.Show();
        }

        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new();
            window4.Show();
        }

        private void Task5Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new();
            window5.Show();
        }
    }
}