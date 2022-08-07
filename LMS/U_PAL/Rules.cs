using LMS.DAL;
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
    public partial class Rules : UserControl
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string rule = textRule.Text;
            DataAccessLayer.AddRule(rule);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void textRegNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
