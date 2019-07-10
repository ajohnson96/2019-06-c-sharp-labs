using System;
using System.Windows;
using System.IO;
using System.Windows.Input;
using System.Windows.Controls;
using System.Diagnostics;

namespace lab_24_gaming_interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public int counter;
        public Stopwatch s = new Stopwatch();
        public long[] time;



        public MainWindow()
        {
            InitializeComponent();
            CheckForData();
            Initialise();
        }

        void CheckForData()
        {
            if (File.Exists("Title.txt"))
            {
                WelcomeLabel.Content = File.ReadAllText("Title.txt");

            }
            else
            {
                WelcomeLabel.Content = File.ReadAllText("Title.txt");
                File.Create("Title.txt");
            }

            if (File.Exists("Player.txt"))
            {
                Intro.Content = "Welcome back: " + File.ReadAllText("Player.txt");
            }
            else
            {
                Intro.Content = "Please enter a name";
                File.Create("Player.txt");
            }
        }

        void Initialise()
        {
        }
        // when the keyup event takes place, object will be item which cause the event
        // i.e the key we pressed e.g. 'h'. EventArgs is an array of strings which 
        // contains any relevant data for that event.
        private void KeyUp_ChangeTitle(object sender, EventArgs e)
        {
            Intro.Content = "New User: " + InputName.Text;

            // add a line to save to file
            File.WriteAllText("Player.txt", InputName.Text);
        }

        private void ChangeEditMode(object sender, EventArgs e)
        {
            if(EditMode.IsChecked ==true)
            {
                InputName.IsReadOnly = false;
            }
            else
            {
                InputName.IsReadOnly = true;
            }
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //InputName.IsEnabled = false;
                Grid.SetColumn(InputName, 2);
                UpdateData();
            }
        }

        void UpdateData()
        {
            if (File.Exists("Player.txt"))
            {
                Intro.Content = "Welcome : " + File.ReadAllText("Player.txt");
            }
            else
            {
                Intro.Content = "Error - no name found";
                File.Create("Player.txt");
            }
        }

        private void MouseEnter_ChangeColor(object sender, EventArgs e)
        {
            //InputName.Background = new Color.FromRgb(100, 100, 100);
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            if(counter == 1)
            {
                s.Start();
            }
            if (counter == 2)
            {
                s.Stop();
                time[counter - 2] = s.ElapsedMilliseconds;
                Intro.Content = time[counter - 2];
                s.Start();
            }
            if (counter == 3)
            {
                s.Stop();
                time[counter - 2] = s.ElapsedMilliseconds;
                Intro.Content = time[counter - 2];
                s.Start();
            }
            if (counter == 4)
            {
                s.Stop();
                time[counter - 2] = s.ElapsedMilliseconds;
                Intro.Content = time[counter - 2];
                s.Start();
            }
            if (counter == 5)
            {
                s.Stop();
                time[counter - 2] = s.ElapsedMilliseconds;
                Intro.Content = time[counter - 2];
                s.Start();
            }
            if (counter == 6)
            {
                s.Stop();
                time[counter - 2] = s.ElapsedMilliseconds;
                Intro.Content = time[counter - 2];
                s.Start();
                counter = 1;
            }

            player.SoundLocation = counter.ToString() + ".wav";
            player.Play();
        }
    }
}
