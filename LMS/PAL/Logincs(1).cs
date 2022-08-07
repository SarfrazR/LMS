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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmduser.Text =="Student")
            {
                Student student = new Student();
                student.Show();
                this.Hide();
            }
            if (cmduser.Text == "Teacher")
            {
                Teacher student = new Teacher();
                student.Show();
                this.Hide();
            }
            if (cmduser.Text == "Admin")
            {
                Admin student = new Admin();
                student.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnotice_Click(object sender, EventArgs e)
        {
            ViewNotice student = new ViewNotice();
            student.Show();
            this.Hide();
        }

        private void btnrule_Click(object sender, EventArgs e)
        {
            ViewRules student = new ViewRules();
            student.Show();
            this.Hide();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            ViewHistory student = new ViewHistory();
            student.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
