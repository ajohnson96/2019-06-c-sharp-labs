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

namespace lab_42_WPF_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        Customer customer;
        public bool IsEditing = false;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using(var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }
            // EITHER OR MUTALLY EXCLUSIVE
            //ListBoxCustomers.DisplayMemberPath = "ContactName";
            ListBoxCustomers.ItemsSource = customers;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var newCustomer = new Customer() { };

            newCustomer.CustomerID = TextBoxID.Text;
            newCustomer.ContactName = TextBoxName.Text;
            newCustomer.CompanyName = TextBoxCompany.Text;
            newCustomer.City = TextBoxCity.Text;
            newCustomer.Country = TextBoxCountry.Text;

            ListBoxCustomers.ItemsSource = null;
            customers.Add(newCustomer);
            customers.Sort((x, y) => string.Compare(x.CustomerID, y.CustomerID));
            ListBoxCustomers.ItemsSource = customers;
            
            ListBoxLog.Items.Insert(0, "");
            ListBoxLog.Items.Insert(0, DateTime.Now);
            ListBoxLog.Items.Insert(0, "Customer added!");
            ListBoxLog.Items.Insert(0, $"{newCustomer.CustomerID,-7},{newCustomer.CompanyName} from {newCustomer.City}");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBoxID.Clear();
            TextBoxName.Clear();
            TextBoxCompany.Clear();
            TextBoxCity.Clear();
            TextBoxCountry.Clear();

            ListBoxLog.Items.Insert(0, "");
            ListBoxLog.Items.Insert(0, DateTime.Now);
            ListBoxLog.Items.Insert(0, "USER CLEARED TEXT");
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (EditButton.Content.ToString() == "Edit")
            {
                if(customer == null)
                {
                    MessageBox.Show("No customer selected!");
                    return;
                }

                IsEditing = true;

                TextBoxID.IsEnabled = true;
                TextBoxName.IsEnabled = true;
                TextBoxCompany.IsEnabled = true;
                TextBoxCity.IsEnabled = true;
                TextBoxCountry.IsEnabled = true;

                TextBoxID.Background = Brushes.White;
                TextBoxName.Background = Brushes.White;
                TextBoxCompany.Background = Brushes.White;
                TextBoxCity.Background = Brushes.White;
                TextBoxCountry.Background = Brushes.White;

                EditButton.Content = "Save";
            }
            else if (EditButton.Content.ToString() == "Save")
            {
                customer.CustomerID = TextBoxID.Text;
                customer.ContactName = TextBoxName.Text;
                customer.CompanyName = TextBoxCompany.Text;
                customer.City = TextBoxCity.Text;
                customer.Country = TextBoxCountry.Text;

                ListBoxCustomers.ItemsSource = null;
                customers.Sort((x, y) => string.Compare(x.CustomerID, y.CustomerID));
                ListBoxCustomers.ItemsSource = customers;

                using (var db = new NorthwindEntities())
                {
                    Customer customerToEdit = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                    customerToEdit.ContactName = TextBoxName.Text;
                    customerToEdit.CompanyName = TextBoxCompany.Text;
                    customerToEdit.City = TextBoxCity.Text;
                    customerToEdit.Country = TextBoxCountry.Text;
                    db.SaveChanges();

                    ListBoxCustomers.ItemsSource = null;
                    customers = db.Customers.ToList();
                    customers.Sort((x, y) => string.Compare(x.CustomerID, y.CustomerID));
                    ListBoxCustomers.ItemsSource = customers;
                }
                EditButton.Content = "Edit";
            }
            


        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(DeleteButton.Content.ToString() == "Delete")
            {
                if(customer == null)
                {
                    MessageBox.Show("No customer selected");
                    return;
                }
                DeleteButton.Content = "Confirm?";
                DeleteButton.Background = Brushes.Red;
            }
            else if(DeleteButton.Content.ToString() == "Confirm")
            {
                IsEditing = true;
                customers.Remove(customer);

                ListBoxCustomers.ItemsSource = null;
                customers.Sort((x, y) => string.Compare(x.CustomerID, y.CustomerID));
                ListBoxCustomers.ItemsSource = customers;

                using (var db = new NorthwindEntities())
                {
                    ;
                }
            }

        }

        private void ListBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(IsEditing == false)
            {
                customer = (Customer)ListBoxCustomers.SelectedItem;
                ListBoxLog.Items.Insert(0, "");
                ListBoxLog.Items.Insert(0, DateTime.Now);
                ListBoxLog.Items.Insert(0, "Customer selected");
                ListBoxLog.Items.Insert(0, $"{customer.CustomerID,-7},{customer.CompanyName} from {customer.City}");

                // add customer details to seperate text boxes
                //ID
                TextBoxID.Text = customer.CustomerID;

                //Name
                TextBoxName.Text = customer.ContactName;

                //Company
                TextBoxCompany.Text = customer.CompanyName;

                //City
                TextBoxCity.Text = customer.City;

                //Country
                TextBoxCountry.Text = customer.Country;
            }
            TextBoxID.IsEnabled =       false;
            TextBoxName.IsEnabled =     false;
            TextBoxCompany.IsEnabled =  false;
            TextBoxCity.IsEnabled =     false;
            TextBoxCountry.IsEnabled =  false;

            IsEditing = false;
        }
    }
}
