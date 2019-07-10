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

namespace lab_39_button_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttons = new List<Button>();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

       void Initialise()
        {
            for(int i = 0; i<100;i++)
            {
                RandomNumberGenerator();
                int v = RandomNumberGenerator();
                //var colour = (Colours)v;
                var b = new Button();
                b.Name = "Button" + (i+1);
                b.Content = (i+1);
                b.Click += new RoutedEventHandler(button_click);

                buttons.Add(b);
                MainGrid.Children.Add(b);
                Grid.SetColumn(b, i % 10);
                Grid.SetRow(b, i / 10);

                System.Threading.Thread.Sleep(10);
                if(v == 0)
                {
                    b.Background = Brushes.Blue;
                }
                else if(v==1)
                {
                    b.Background = Brushes.Red;
                }
                else if (v == 2)
                {
                    b.Background = Brushes.Green;
                }
                else if (v == 3)
                {
                    b.Background = Brushes.Yellow;
                }
                else if (v == 4)
                {
                    b.Background = Brushes.Purple;
                }
                else if (v == 1)
                {
                    b.Background = Brushes.Pink;
                }

            }

        }

        private void button_click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            MessageBox.Show($"You click on button number {b.Name} at row {Grid.GetRow(b) + 1} and column {Grid.GetColumn(b) + 1}");

        }

        private int RandomNumberGenerator()
        {
            // generate a random number between 1 and 6
            Random r = new Random();
            int rInt = r.Next(0, 5);
            return rInt;
        }
    }

    enum Colours
    {
        blue,red,green,yellow,purple,pink
    }
}
