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
    public partial class teacherassign : UserControl
    {
        public teacherassign()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            U_PAL.addcourseassign hc = new U_PAL.addcourseassign();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            U_PAL.viewteacherassign hc = new U_PAL.viewteacherassign();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            U_PAL.updatesubject hc = new U_PAL.updatesubject();
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
