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
    public partial class addteacherinfo : UserControl
    {
        public addteacherinfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            int salary = int.Parse(txtSalary.Text);
            string tid = txtTid.Text;
            string Qual = txtQualification.Text;
            string specialliaztaion = txtspeciallization.Text;

            try
            {
                DataAccessLayer.AddTeacherRecord(tid, password, fName, lName, address, city, gender, email, username, specialliaztaion, depart, bGroup, salary, Qual);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
