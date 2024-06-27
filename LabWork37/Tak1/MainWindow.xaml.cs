using System.IO;
using System.Windows;
using System.Windows.Shapes;

namespace Tak1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var path = @"C:\temp\ispp21";
            DirectoryInfo directory = new DirectoryInfo(path);

            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            //var result = files.Where().ToList();
            resultDataGrid.ItemsSource = files.ToList();
        }
    }
}