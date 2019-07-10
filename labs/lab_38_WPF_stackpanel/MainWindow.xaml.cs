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

namespace lab_38_WPF_stackpanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> questions = new List<string>();
        public List<QuestionBank> questionsWithAnswers = new List<QuestionBank>();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Hidden;

            questions.Add("What is the captitol of Italy?");
            questions.Add("What is the captitol of Mongolia");
            questions.Add("How do you spell LLanfair.... fully?");
            questions.Add("What is 1/0 * 3");
            questions.Add("Who is the prime minister of Singapore");

            var qanda01 = new QuestionBank("What is the capitol of Italy", "Rome", 100);
            var qanda02 = new QuestionBank("What is the capitol of Mongolia", "Ulaanbaatar", 1000);
            var qanda03 = new QuestionBank("How do you spell LLanfair.... fully?", "Llanfairpwllgwyngyllgogerychwyrndrobwllllantysiliogogogoch", 3000);
            var qanda04 = new QuestionBank("What is 1/0 * 3", "0", 100);
            var qanda05 = new QuestionBank("Who is the prime minister of Singapore", "Halimah Yacob", 2000);

            // classwork and homework
            // create a game to randomly show one of the questions.
            // have a text box to reciever the answer
            // if its right display appropriate message and add to total points
            // if wrong zero points and appropriate message
            // create a win state
            // add some imagery as well
        }

        private void ShowPanel01(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Hidden;
        }

        private void ShowPanel02(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Hidden;
            StackPanel02.Visibility = Visibility.Visible;
            StackPanel03.Visibility = Visibility.Hidden;
        }

        private void ShowPanel03(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Hidden;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Visible;
        }
    }

    public class QuestionBank
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Points { get; set; }
        public QuestionBank(string question, string answer, int points)
        {
            question = this.Question;
            answer = this.Answer;
            points = this.Points;
        }
    }
}
