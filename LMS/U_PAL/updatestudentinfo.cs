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
    public partial class updatestudentinfo : UserControl
    {
        public updatestudentinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            PAL.Admin ad = new PAL.Admin();
            ad.Show();
            this.Hide();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            string fName = txtFname.Text;
            string lName = txtLname.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string gender = cmbGender.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtpassword.Text;
            string depart = txtDept.Text;
            string bGroup = cmbBGroup.Text;
            int fee = int.Parse(txtFee.Text);
            string reg = txtreg.Text;
            string gName = txtGName.Text;
            string GRelation = txtGRelation.Text;
            string GPhone = txtGPhone.Text;
            string semester = txtSem.Text;

            try
            {
                DataAccessLayer.UpdateStudentRecord(reg, password, fName, lName, address, city, gender, email, username, GRelation, depart, bGroup, fee, semester, gName, semester);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatestudentinfo_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
