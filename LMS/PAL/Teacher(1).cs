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
    public partial class Teacher : Form
    {
        public Teacher()
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
            U_PAL.TeacherPersonal hc = new U_PAL.TeacherPersonal();
            panelmaint.Controls.Add(hc);
            hc.Width = panelmaint.Width;
            hc.Height = panelmaint.Height;
            hc.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            U_PAL.teacherenrollcourse hc = new U_PAL.teacherenrollcourse();
            panelmaint.Controls.Add(hc);
            hc.Width = panelmaint.Width;
            hc.Height = panelmaint.Height;
            hc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            U_PAL.editresult hc = new U_PAL.editresult();
            panelmaint.Controls.Add(hc);
            hc.Width = panelmaint.Width;
            hc.Height = panelmaint.Height;
            hc.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            U_PAL.PaySlip hc = new U_PAL.PaySlip();
            panelmaint.Controls.Add(hc);
            hc.Width = panelmaint.Width;
            hc.Height = panelmaint.Height;
            hc.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            U_PAL.Stdtimetable hc = new U_PAL.Stdtimetable();
            panelmaint.Controls.Add(hc);
            hc.Width = panelmaint.Width;
            hc.Height = panelmaint.Height;
            hc.BringToFront();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
