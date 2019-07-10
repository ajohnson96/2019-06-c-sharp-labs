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

namespace lab_48_business_search
{
    public partial class MainWindow : Window
    {
        List<String> cities;
        List<Customer> searchCustomers;

        static List<Customer> customers;
        static List<Product> products;
        static List<Employee> employees;

        static List<Customer> retCustomers;
        static List<Product> retProducts;
        static List<Employee> retEmployees;

        string currentTab;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                products = db.Products.ToList();
                employees = db.Employees.ToList();

                cities = (from c in db.Customers.ToList() select c.City).Distinct().ToList();
            }
            ListViewCustomers.ItemsSource = customers;
            ListViewProducts.ItemsSource = products;
            ListViewEmployees.ItemsSource = employees;

            ComboBoxCity.ItemsSource = cities;

            currentTab = "Employee";
        }

        private void ListViewEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e){}

        private void ListViewCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e){}

        private void ListViewProducts_SelectionChanged(object sender, SelectionChangedEventArgs e){}

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {}

        private void InputName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TabControl01.SelectedIndex == 0)
            {
                currentTab = "Employee";
            }
            if (TabControl01.SelectedIndex == 1)
            {
                currentTab = "Product";
            }
            if (TabControl01.SelectedIndex == 2)
            {
                currentTab = "Customer";
            }

            using (var db = new NorthwindEntities())
            {
                if (currentTab == "Employee")
                {
                    retEmployees = db.Employees.Where(p => p.FirstName.Contains(InputText.Text)).ToList();

                    // set new display for Employees
                    ListViewEmployees.ItemsSource = null;
                    ListViewEmployees.ItemsSource = retEmployees;

                    // reset display for others
                    ListViewProducts.ItemsSource = null;
                    ListViewProducts.ItemsSource = products;

                    ListViewCustomers.ItemsSource = null;
                    ListViewCustomers.ItemsSource = customers;
                }
                if (currentTab == "Product")
                {
                    retProducts = db.Products.Where(p => p.ProductName.Contains(InputText.Text)).ToList();

                    // set new display for Products
                    ListViewProducts.ItemsSource = null;
                    ListViewProducts.ItemsSource = retProducts;

                    // reset display for others
                    ListViewEmployees.ItemsSource = null;
                    ListViewEmployees.ItemsSource = employees;

                    ListViewCustomers.ItemsSource = null;
                    ListViewCustomers.ItemsSource = customers;
                }
                if (currentTab == "Customer")
                {
                    retCustomers = db.Customers.Where(p => p.ContactName.Contains(InputText.Text)).ToList();

                    // set new display for Customers
                    ListViewCustomers.ItemsSource = null;
                    ListViewCustomers.ItemsSource = retCustomers;

                    // reset display for others
                    ListViewProducts.ItemsSource = null;
                    ListViewProducts.ItemsSource = products;

                    ListViewEmployees.ItemsSource = null;
                    ListViewEmployees.ItemsSource = employees;
                }
            }
        }

        private void InputID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TabControl01.SelectedIndex == 0)
            {
                currentTab = "Employee";
            }
            if (TabControl01.SelectedIndex == 1)
            {
                currentTab = "Product";
            }
            if (TabControl01.SelectedIndex == 2)
            {
                currentTab = "Customer";
            }

            using (var db = new NorthwindEntities())
            {
                if (currentTab == "Employee")
                {
                    retEmployees = db.Employees.Where(p => p.EmployeeID.ToString().Contains(InputID.Text)).ToList();

                    // set new display for Employees
                    ListViewEmployees.ItemsSource = null;
                    ListViewEmployees.ItemsSource = retEmployees;

                    // reset display for others
                    ListViewProducts.ItemsSource = null;
                    ListViewProducts.ItemsSource = products;

                    ListViewCustomers.ItemsSource = null;
                    ListViewCustomers.ItemsSource = customers;
                }
                if (currentTab == "Product")
                {
                    retProducts = db.Products.Where(p => p.ProductID.ToString().Contains(InputID.Text)).ToList();

                    // set new display for Products
                    ListViewProducts.ItemsSource = null;
                    ListViewProducts.ItemsSource = retProducts;

                    // reset display for others
                    ListViewEmployees.ItemsSource = null;
                    ListViewEmployees.ItemsSource = employees;

                    ListViewCustomers.ItemsSource = null;
                    ListViewCustomers.ItemsSource = customers;
                }
                if (currentTab == "Customer")
                {
                    retCustomers = db.Customers.Where(p => p.CustomerID.ToString().Contains(InputID.Text)).ToList();

                    // set new display for Customers
                    ListViewCustomers.ItemsSource = null;
                    ListViewCustomers.ItemsSource = retCustomers;

                    // reset display for others
                    ListViewProducts.ItemsSource = null;
                    ListViewProducts.ItemsSource = products;

                    ListViewEmployees.ItemsSource = null;
                    ListViewEmployees.ItemsSource = employees;
                }
            }
        }

        private void ComboBoxCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var city = ComboBoxCity.SelectedItem;
            MessageBox.Show($"You chose city {city}");
            using (var db = new NorthwindEntities())
            {
                searchCustomers = db.Customers.Where(c => c.City == (string)city).ToList();
                ListViewCustomers.ItemsSource = null;
                ListViewCustomers.ItemsSource = searchCustomers;
            }
        }
    }
}
