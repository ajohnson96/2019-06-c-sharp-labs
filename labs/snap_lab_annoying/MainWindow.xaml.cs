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

namespace snap_lab_annoying
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int box1Counter;
        private int box2Counter;
        private int box3Counter;
        private int box4Counter;

        public MainWindow()
        {
            InitialiseHell();
        }

        public void InitialiseHell()
        {
            box1Counter = 0;
            box2Counter = 0;
            box3Counter = 0;
            box4Counter = 0;
        }

        private void OnBox1Click(object sender, EventArgs e)
        {
            if (box1Counter == 0)
            {
                Grid.SetColumn(Box1, box1Counter + 1);
            }
            else if (box1Counter == 1)
            {
                Grid.SetColumn(Box1, box1Counter + 1);
            }
            else if (box1Counter == 2)
            {
                Grid.SetColumn(Box1, box1Counter + 1);
                Grid.SetColumnSpan(Box1, 2);
            }
            box1Counter++;
        }

        private void OnBox2Click(object sender, EventArgs e)
        {
            if (box2Counter == 0)
            {
                System.Threading.Thread.Sleep(500);
                Grid.SetColumn(Box2, box2Counter + 1);
            }
            else if (box2Counter == 1)
            {
                System.Threading.Thread.Sleep(500);
                Grid.SetColumn(Box2, box2Counter + 1);
            }
            else if (box2Counter == 2)
            {
                System.Threading.Thread.Sleep(500);
                Grid.SetColumn(Box2, box2Counter + 1);
                Grid.SetColumnSpan(Box1, 2);
            }
            box2Counter++;
        }

        private void OnBox3Click(object sender, EventArgs e)
        {
            if (box3Counter == 0)
            {
                System.Threading.Thread.Sleep(250);
                Grid.SetColumn(Box3, box3Counter + 1);
            }
            else if (box3Counter == 1)
            {
                System.Threading.Thread.Sleep(750);
                Grid.SetColumn(Box3, box3Counter + 1);
            }
            else if (box3Counter == 2)
            {
                Grid.SetColumn(Box3, box3Counter + 1);
                Box3.Background = Brushes.Transparent;
            }
            box3Counter++;
        }

        private void OnBox4Click(object sender, EventArgs e)
        {
            if (box4Counter == 0)
            {
                System.Threading.Thread.Sleep(500);
                Grid.SetColumn(Box4, box4Counter + 1);
            }
            else if (box4Counter == 1)
            {
                System.Threading.Thread.Sleep(500);
                Grid.SetColumn(Box4, box4Counter + 1);
            }
            else if (box4Counter == 2)
            {
                System.Threading.Thread.Sleep(2000);
                Grid.SetColumn(Box4, box4Counter + 1);
                Box4.Background = Brushes.Blue;
                Grid.SetColumnSpan(Box1, 2);
            }
            box4Counter++;
        }
    }
}
