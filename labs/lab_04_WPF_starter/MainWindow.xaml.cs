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

namespace lab_04_WPF_starter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            List<string> comboItems = new List<string>() { "One", "Two", "Three" };
            Combobox01.ItemsSource = comboItems;
        }


        private void Text01_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            List01.Items.Add($"You have clicked {counter} times");

        }

        private void List01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Combobox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = Combobox01.SelectedItem;
            List01.Items.Add(selectedItem);
        }
    }
}
