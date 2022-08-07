using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.U_PAL
{
    public partial class studentmain : UserControl
    {
        public studentmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            U_PAL.addstudentinfo hc = new U_PAL.addstudentinfo();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            U_PAL.updatestudentinfo hc = new U_PAL.updatestudentinfo();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            U_PAL.EnrollStudent hc = new U_PAL.EnrollStudent();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }
    }
}
