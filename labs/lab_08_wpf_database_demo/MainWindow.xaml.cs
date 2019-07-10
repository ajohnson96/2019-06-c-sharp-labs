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

namespace lab_08_wpf_database_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customers = new List<Customer>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }
            ListBox01.DisplayMemberPath = "ContactName";
            ListBox01.ItemsSource = customers;
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
