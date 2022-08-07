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
    public partial class coursemain : UserControl
    {
        public coursemain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            U_PAL.teacherassign hc = new U_PAL.teacherassign();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            U_PAL.course1 hc = new U_PAL.course1();
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
