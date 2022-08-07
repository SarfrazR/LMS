using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.PAL
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            U_PAL.adminpersonal1 hc = new U_PAL.adminpersonal1();
            panelmain2.Controls.Add(hc);
            hc.Width = panelmain2.Width;
            hc.Height = panelmain2.Height;
            hc.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            U_PAL.coursemain hc = new U_PAL.coursemain();
            panelmain2.Controls.Add(hc);
            hc.Width = panelmain2.Width;
            hc.Height = panelmain2.Height;
            hc.BringToFront();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            U_PAL.studentmain hc = new U_PAL.studentmain();
            panelmain2.Controls.Add(hc);
            hc.Width = panelmain2.Width;
            hc.Height = panelmain2.Height;
            hc.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            U_PAL.teachermain hc = new U_PAL.teachermain();
            panelmain2.Controls.Add(hc);
            hc.Width = panelmain2.Width;
            hc.Height = panelmain2.Height;
            hc.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            U_PAL.Classschedule_Main hc = new U_PAL.Classschedule_Main();
            panelmain2.Controls.Add(hc);
            hc.Width = panelmain2.Width;
            hc.Height = panelmain2.Height;
            hc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            U_PAL.Rules hc = new U_PAL.Rules();
            panelmain2.Controls.Add(hc);
            hc.Width = panelmain2.Width;
            hc.Height = panelmain2.Height;
            hc.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            U_PAL.Notification hc = new U_PAL.Notification();
            panelmain2.Controls.Add(hc);
            hc.Width = panelmain2.Width;
            hc.Height = panelmain2.Height;
            hc.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            U_PAL.About hc = new U_PAL.About();
            panelmain2.Controls.Add(hc);
            hc.Width = panelmain2.Width;
            hc.Height = panelmain2.Height;
            hc.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
