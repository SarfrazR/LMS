using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.PAL
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            U_PAL.StudentPersonal hc = new U_PAL.StudentPersonal();
            panelmain.Controls.Add(hc);
            hc.Width = panelmain.Width;
            hc.Height = panelmain.Height;
            hc.BringToFront();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            panelmain.Visible = true;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            U_PAL.EnrollCourses hc = new U_PAL.EnrollCourses();
            panelmain.Controls.Add(hc);
            hc.Width = panelmain.Width;
            hc.Height = panelmain.Height;
            hc.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            U_PAL.Result hc = new U_PAL.Result();
            panelmain.Controls.Add(hc);
            hc.Width = panelmain.Width;
            hc.Height = panelmain.Height;
            hc.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            U_PAL.FeeSlip hc = new U_PAL.FeeSlip();
            panelmain.Controls.Add(hc);
            hc.Width = panelmain.Width;
            hc.Height = panelmain.Height;
            hc.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            U_PAL.Stdtimetable hc = new U_PAL.Stdtimetable();
            panelmain.Controls.Add(hc);
            hc.Width = panelmain.Width;
            hc.Height = panelmain.Height;
            hc.BringToFront();
        }
    }
}
