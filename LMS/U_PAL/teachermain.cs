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
    public partial class teachermain : UserControl
    {
        public teachermain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            U_PAL.addteacherinfo hc = new U_PAL.addteacherinfo();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            U_PAL.updatetecherinfo hc = new U_PAL.updatetecherinfo();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            U_PAL.Teacherenroll hc = new U_PAL.Teacherenroll();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
