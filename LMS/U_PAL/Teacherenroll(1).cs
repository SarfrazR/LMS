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
    public partial class Teacherenroll : UserControl
    {
        public Teacherenroll()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PAL.Admin ad = new PAL.Admin();
            ad.Show();
            this.Hide();
        }
    }
}
