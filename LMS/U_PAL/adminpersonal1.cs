using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.U_PAL
{
    public partial class adminpersonal1 : UserControl
    {
        public adminpersonal1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            U_PAL.AdminPersonal hc = new U_PAL.AdminPersonal();
            panelpersonal.Controls.Add(hc);
            hc.Width = panelpersonal.Width;
            hc.Height = panelpersonal.Height;
            hc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            U_PAL.adminpersonalview hc = new U_PAL.adminpersonalview();
            panelpersonal.Controls.Add(hc);
            hc.Width = panelpersonal.Width;
            hc.Height = panelpersonal.Height;
            hc.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            U_PAL.deleteadminper hc = new U_PAL.deleteadminper();
            panelpersonal.Controls.Add(hc);
            hc.Width = panelpersonal.Width;
            hc.Height = panelpersonal.Height;
            hc.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            U_PAL.updateadmin hc = new U_PAL.updateadmin();
            panelpersonal.Controls.Add(hc);
            hc.Width = panelpersonal.Width;
            hc.Height = panelpersonal.Height;
            hc.BringToFront();
        }

        private void panelpersonal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
