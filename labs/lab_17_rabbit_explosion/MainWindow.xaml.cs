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

namespace lab_17_rabbit_explosion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static int counter = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // starts at zero so first click means first rabbit is 1
            counter++;

            var r = new Rabbit(0, counter);
            rabbits.Add(r);

            ListBox01.Items.Clear();

            foreach(Rabbit rabbit in rabbits)
            {
                rabbit.Age++;
                ListBox01.Items.Add($"{rabbit.GetName("Anthing"),-2} has age {rabbit.Age}");
                //ListBox01.ItemsSource = rabbits;
            }

            Rabbit01.Opacity = counter / 100;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
