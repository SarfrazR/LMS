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
    public partial class addcourseassign : UserControl
    {
        public addcourseassign()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StudID = textSID.Text;
            string TeachID = textTID.Text;
            int Marks = int.Parse(textTotalMarks.Text);
            DataAccessLayer.AddCourseAssign(StudID, TeachID, Marks);
        }
    }
}
