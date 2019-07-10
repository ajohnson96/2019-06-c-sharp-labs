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

namespace lab_44_WPF_StackPanelTest
{

    public partial class MainWindow : Window
    {
        static List<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using(var db = new NorthwindEntities())
            {
                employees = db.Employees.ToList();
            }
            //SurnamesBox01.DisplayMemberPath = employees.;
            ListViewEmployees.ItemsSource = employees;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(SurnameTab.IsSelected == true)
            {

            }
        }
    }
}
