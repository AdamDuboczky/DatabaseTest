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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NewBookWindow.xaml
    /// </summary>
    public partial class NewBookWindow : Window
    {
        public Book Book { get; private set; }
        public NewBookWindow()
        {
            InitializeComponent();
        }

        private void InsertButtonClick(object sender, RoutedEventArgs e)
        {
             Book = new ConsoleApp1.Book(TitleInput.Text = "a", AuthorInput.Text = "a" , Double.Parse(PriceInput.Text), int.Parse(QuantityInput.Text));
            DialogResult = true;

            
        }

        private void CancelButtonClicked(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
