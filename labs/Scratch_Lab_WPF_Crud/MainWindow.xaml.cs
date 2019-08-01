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

namespace Scratch_Lab_WPF_Crud
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
            Initialise();
        }

        void Initialise()
        {
            using (var db = new NorthwindEntities1())
            {
                customers = db.Customers.ToList();
            }
            ListBoxCustomers.ItemsSource = customers;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            var newCustomer2 = new Customer()
            {
                ContactName = "Gary Sheen",
                CompanyName = "Chuck Lorre Productions",
                CustomerID = "L0SNG",
                City = "Miami",
                Country = "U.S.A",
            };

            using (var db = new NorthwindEntities1())
            {
                var customerToDelete = customers.Find(x => x.CustomerID.Contains("W1NNG"));
                customers.Remove(customerToDelete);

                customers = db.Customers.ToList();
                customers.Add(newCustomer2);
                int affect = db.SaveChanges();

                ListBoxCustomers.ItemsSource = null;
                ListBoxCustomers.ItemsSource = customers;
                customers.Sort((x, y) => string.Compare(x.CustomerID, y.CustomerID));
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            /* SELECT CUSTOMER */
            using (var db = new NorthwindEntities1())
            {
                customers = db.Customers.ToList();
                var customerToEdit = customers.Find(x => x.ContactName.Contains("Charlie"));

                /* UPDATE CUSTOMER */
                customerToEdit.ContactName = "Charlie Beenupdated";
                int affected = db.SaveChanges();

                ListBoxCustomers.ItemsSource = null;
                ListBoxCustomers.ItemsSource = customers;
                //customers.Sort((x, y) => string.Compare(x.CustomerID, y.CustomerID));
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            /* DELETE CUSTOMER */
            var customerToDelete = customers.Find(x => x.ContactName.Contains("Charlie"));
            customers.Remove(customerToDelete);
            using (var db = new NorthwindEntities1())
            {
                db.SaveChanges();

                ListBoxCustomers.ItemsSource = null;
                ListBoxCustomers.ItemsSource = customers;
                customers.Sort((x, y) => string.Compare(x.CustomerID, y.CustomerID));
            }
        }

        public void ListAll(List<Customer> CustomerList)
        {
            using (var db = new NorthwindEntities1())
            {
                customers = db.Customers.ToList();
            }
        }

        private void ListBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
