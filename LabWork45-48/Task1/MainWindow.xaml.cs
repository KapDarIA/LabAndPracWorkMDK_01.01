using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Windows;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            connectionLabel.Content = DataAccessLayer.ConnectionString;
        }

        private void ComplateTask2Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                infoTextBlock.Text = $"Вывод: \n{DataAccessLayer.GetObject(sqlCommandTextBox.Text)}";
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        private void ComplateTask3Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                infoDataGrid.ItemsSource = DataAccessLayer.GetTable(sqlCommandTextBox.Text).DefaultView;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        private void ComplateTask4Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                infoDataGrid.ItemsSource = DataAccessLayer.GetBooks();
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        // LabWork46 
        //Task1

        private void ComplateButton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //UPDATE Games SET Price = Price + 1
                stringLabel.Content = $"Количество измененых строк: {DataAccessLayer.GetCountChangedRows(sqlCommandTextBox.Text)}";
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        //Task2

        private void ComplateButton2_Click(object sender, RoutedEventArgs e)
        {

            if (DataAccessLayer.UpdatePrice(Convert.ToInt32(idTextBox1.Text), Convert.ToInt32(priceTextBox1.Text)) == true)
                MessageBox.Show("Цена изменена успешно");
            else
                MessageBox.Show("Не удалось выполнить запрос");
        }

        //Task3

        private void ComplateButton3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                infoDataGrid.ItemsSource = DataAccessLayer.GetTableByName(tableTextBox1.Text).DefaultView;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        //Task4

        private void ComplateButton4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                infoDataGrid.ItemsSource = DataAccessLayer.GetTableByName(tableTextBox2.Text).DefaultView;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataView dataView = (DataView)infoDataGrid.ItemsSource;
                DataTable dataTable = dataView.Table;
                DataAccessLayer.UpdateTable(ref dataTable, tableTextBox2.Text);

                MessageBox.Show("Таблица сохранена!");
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        // LabWork47
        //Task1

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            int price = Convert.ToInt32(priceTextBox2.Text);

            if (DataAccessLayer.GetBooksCountByPrice(price) != -1)
            {

                MessageBox.Show($"Количество книг с ценой меньше {price}: {DataAccessLayer.GetBooksCountByPrice(price)}");
            }
            else
                MessageBox.Show("Не удалось выполнить запрос");
        }

        //Task2

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //INSERT INTO [dbo].[Book] ([AuthorId], [Title], [Genre], [Price],[Weight], [Pages], [PublicationYear]) VALUES ('4', 'Восточные сказки', 'проза', 1500, 0.599, 250, 988)
                MessageBox.Show($"ID добавленной книги: {DataAccessLayer.GetNewRecordId(sqlCommandTextBox.Text)}");
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        //Task3

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                infoDataGrid.ItemsSource = DataAccessLayer.GetBooks(genreTextBox.Text,
                           Convert.ToDecimal(priceTextBox3.Text)).DefaultView;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        //Task4

        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataAccessLayer.ChangeBookById(Convert.ToInt32(idTextBox2.Text), Convert.ToDecimal(priceTextBox4.Text), titleTextBox.Text) == true)
                MessageBox.Show("Данные успешно изменены");
            else
                MessageBox.Show("Не удалось выполнить запрос");
        }

        //LabWork48
        //Task2

        private void Task5Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (surnameTextBox1.Text.IsNullOrEmpty() != true || nameTextBox1.Text.IsNullOrEmpty() != true || countryTextBox1.Text.IsNullOrEmpty() != true)
                {
                    DataAccessLayer.AddAuthor(surnameTextBox1.Text, nameTextBox1.Text, countryTextBox1.Text);
                    MessageBox.Show($"{surnameTextBox1.Text} {nameTextBox1.Text} добавлен в БД");
                }
                else
                    MessageBox.Show("Заполните ячейки");
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        //Task3

        private void Task6Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (surnameTextBox1.Text.IsNullOrEmpty() != true || nameTextBox1.Text.IsNullOrEmpty() != true || countryTextBox1.Text.IsNullOrEmpty() != true)
                    MessageBox.Show($"{surnameTextBox2.Text} {nameTextBox2.Text} добавлен в БД c Id:{DataAccessLayer.GetAuthorId(surnameTextBox2.Text, nameTextBox2.Text, countryTextBox2.Text)}");
                else
                    MessageBox.Show("Заполните ячейки");
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }
        }

        private void Task7Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                infoDataGrid.ItemsSource = DataAccessLayer.GetBooksPriceInRange(Convert.ToDecimal(firstPriceTextBox.Text), Convert.ToDecimal(lastPriceTextBox.Text)).DefaultView;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запрос");
            }

        }
    }
}