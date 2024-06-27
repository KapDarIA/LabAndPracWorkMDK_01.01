using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Game> games = new List<Game>()
            {
                new Game{IdGame=1,Name="Смута", Site="https://steam.com", Category="Симулятор диалогов",Price=2000},
                 new Game{IdGame=2,Name="CS 2", Site="https://steam.com", Category="Shooter",Price=100},
                  new Game{IdGame=3,Name="WoW", Site="https://steam.com", Category="RPG",Price=300},
                   new Game{IdGame=4,Name="Супер корова", Site="https://steam.com", Category="RPG",Price=1000},
                    new Game{IdGame=5,Name="Genshin", Site="https://steam.com", Category="Rogalic",Price=0}
            };
            GameDataGrid.ItemsSource = games;
        }
    }
}