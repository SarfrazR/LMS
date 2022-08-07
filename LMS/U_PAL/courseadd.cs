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
    public partial class courseadd : UserControl
    {
        public courseadd()
        {
            InitializeComponent();
            lblCHours.Hide();
            lblCName.Hide();
            lblC_ID.Hide();
            lblOffSem.Hide();
            txtAddC_Hours.Hide();
            txtAddC_ID.Hide();
            txtAddC_Name.Hide();
            txtAddOffSem.Hide();
            txtUpdC_hours.Hide();
            txtUpdC_ID.Hide();
            txtUpdC_Name.Hide();
            txtUpdOffSem.Hide();
            btnDoneAdd.Hide();
            btnDoneUpd.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PAL.Admin ad = new PAL.Admin();
            ad.Show();
            this.Hide();
        }

        private void courseadd_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCHours.Show();
            lblCName.Show();
            lblC_ID.Show();
            lblOffSem.Show();
            txtAddC_Hours.Show();
            txtAddC_ID.Show();
            txtAddC_Name.Show();
            txtAddOffSem.Show();
            txtUpdC_hours.Hide();
            txtUpdC_ID.Hide();
            txtUpdC_Name.Hide();
            txtUpdOffSem.Hide();
            btnDoneAdd.Show();
            btnDoneUpd.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCHours.Show();
            lblCName.Show();
            lblC_ID.Show();
            lblOffSem.Show();
            txtAddC_Hours.Hide();
            txtAddC_ID.Hide();
            txtAddC_Name.Hide();
            txtAddOffSem.Hide();
            txtUpdC_hours.Show();
            txtUpdC_ID.Show();
            txtUpdC_Name.Show();
            txtUpdOffSem.Show();
            btnDoneAdd.Hide();
            btnDoneUpd.Show();
        }

        private void btnDoneAdd_Click(object sender, EventArgs e)
        {
            string CourseID = txtAddC_ID.Text;
            string C_Name = txtAddC_Name.Text;
            string c_CHours = txtAddC_Hours.Text;
            string OffSem = txtAddOffSem.Text;
            DataAccessLayer.AddCourseRecord(CourseID, C_Name, c_CHours,OffSem);
            MessageBox.Show("Data Added");
        }

        private void btnDoneUpd_Click(object sender, EventArgs e)
        {
            string CourseID = txtAddC_ID.Text;
            string C_Name = txtAddC_Name.Text;
            string c_CHours = txtAddC_Hours.Text;
            string offSem = txtUpdOffSem.Text;
            DataAccessLayer.UpdateCourseRecord(CourseID, C_Name, c_CHours,offSem);
            MessageBox.Show("Data Updated!");
        }
    }
}
