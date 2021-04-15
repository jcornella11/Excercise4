using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise4
{
    public partial class Form1 : Form
    {
        double seconds, minutes, hours, days, totalseconds;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalseconds = Convert.ToDouble(textBox1.Text);

            if (totalseconds >= 60 && totalseconds < 3600)
            {
                minutes = totalseconds / 60;
                label2.Visible = true;
                label2.Text = "Number of Minutes: ";
                textBox3.Text = Convert.ToString(minutes);
            }
            else if (totalseconds >= 3600 && totalseconds < 86400)
            {
                hours = totalseconds / 3600;
                label2.Visible = true;
                label2.Text = "Number of Hours: ";
                textBox3.Text = Convert.ToString(hours);
            }
            else if (totalseconds >= 86400)
            {
                days = totalseconds / 86400;
                label2.Visible = true;
                label2.Text = "Number of Days: ";
                textBox3.Text = Convert.ToString(days);
            }
            else
            {
                seconds = totalseconds;
                label2.Visible = true;
                label2.Text = "Number of Seconds: ";
                textBox3.Text = Convert.ToString(seconds);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
