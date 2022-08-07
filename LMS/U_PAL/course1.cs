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
    public partial class course1 : UserControl
    {
        public course1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            U_PAL.courseadd hc = new U_PAL.courseadd();
            panel1.Controls.Add(hc);
            hc.Width = panel1.Width;
            hc.Height = panel1.Height;
            hc.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            U_PAL.btnviewcourse hc = new U_PAL.btnviewcourse();
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
