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
    public partial class Teachertimetable : UserControl
    {
        public Teachertimetable()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
