using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Desktop_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToLongTimeString();
            this.label2.Text = DateTime.Now.DayOfWeek.ToString();

            string month = "";
            switch (DateTime.Now.Month.ToString())
            {
                case "1": month = "Jaunary"; break;
                case "2": month = "February"; break;
                case "3": month = "March"; break;
                case "4": month = "April"; break;
                case "5": month = "May"; break;
                case "6": month = "June"; break;
                case "7": month = "July"; break;
                case "8": month = "August"; break;
                case "9": month = "September"; break;
                case "10": month = "October"; break;
                case "11": month = "November"; break;
                case "12": month = "December"; break;

                default:
                    break;
            }

            string day = DateTime.Now.Day.ToString();
            string a = " ";
            string b = string.Format("{0} {1} {2}", month, a, day);
            this.label3.Text = b;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int startX = 0, startY = 0;

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - startY;
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X;
                startY = e.Y;
            }
        }
    }
}
