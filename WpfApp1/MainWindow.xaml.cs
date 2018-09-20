using ConsoleApp1;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Database database;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectButtonClicked (object sender, RoutedEventArgs e)
        {
            var usernameText = UsernameInput.Text = "root";
            var passwordText = PasswordInput.Text = "changeme";
            var databaseText = DatabaseInput.Text = "ebookshop";

            database = new Database(usernameText, passwordText, databaseText);

            MessageBox.Show("Connected", "Database",MessageBoxButton.OK, MessageBoxImage.Information);
            MainPanel.Visibility = Visibility.Visible;
        }

        private void DisplayButtonClicked(object sender, RoutedEventArgs e)
        {
            var databaseList = database.display();
            DatabaseGrid.ItemsSource = databaseList;
            DatabaseGrid.AutoGenerateColumns = false;



        }

        private void InsertButtonClicked(object sender, RoutedEventArgs e)
        {
            var popUpBox = new NewBookWindow();

            var result = popUpBox.ShowDialog();

            if(result == true)
            {
                database.insert(popUpBox.Book);
            }

        }
    }
}
