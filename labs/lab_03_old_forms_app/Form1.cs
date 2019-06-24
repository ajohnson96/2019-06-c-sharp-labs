using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03_old_forms_app
{
    public partial class Form1 : Form
    {
        static int counter = 0;

        public Form1()
        {
            InitializeComponent();
            Initialise();
        }

        private void Initialise()
        {
            label1.Text = "What is your name?";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Enjoy your stay " + textBox1.Text + "!";
            counter ++;
            label2.Text = counter.ToString();

            if(label2.Text == "7")
            {
                label1.Text = "Lucky you! Good work!";
            }
            else if (counter >= 8 && counter < 13)
            {
                label1.Text = "Alright slow it down...";
            }
            else if (counter >= 13 && counter < 30)
            {
                label1.Text = "Is your mouse broken?";
            }
        }
    }
}
