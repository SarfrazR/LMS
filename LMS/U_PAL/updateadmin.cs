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
    public partial class updateadmin : UserControl
    {
        public updateadmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PAL.Admin ad = new PAL.Admin();
            ad.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string password = txtpassword.Text;
            string Fname = txtFname.Text;
            string Lname = txtLname.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string gender = cmbGender.SelectedItem.ToString();
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            int jobScale = int.Parse(txtJobscale.Text);
            try
            {
                DataAccessLayer.UpdateAdminRecord(Fname, Lname, address, city, gender, email, username, password, jobScale);
                MessageBox.Show("Data Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
