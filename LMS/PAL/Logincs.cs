using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.DAL;
using System.Data;
using System.Data.SqlClient;

namespace LMS.PAL
{
    public partial class Login : Form
    {

        string Next = "";
        public Login()
        {
            InitializeComponent();
            SqlConnection connection = DataAccessLayer.GetSqlConnection();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string username = txtusername.Text;
            //string password = txtpassword.Text;
            //Next = txtusername.Text;
             
            if (cmduser.Text == "Student")
            {
                try
                {
                    //DataAccessLayer.CheckStudent(username, password);
                    Student student = new Student();
                    student.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            if (cmduser.Text == "Teacher")
            {
                try
                {
                    //DataAccessLayer.CheckTeacher(username, password);
                    Teacher student = new Teacher();
                    student.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cmduser.Text == "Admin")
            {
                //DataAccessLayer.CheckAdmin(username, password);
                Admin student = new Admin();
                student.Show();
                this.Hide();
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnotice_Click(object sender, EventArgs e)
        {
            ViewNotice student = new ViewNotice();
            student.Show();
            this.Hide();
        }

        private void btnrule_Click(object sender, EventArgs e)
        {
            ViewRules student = new ViewRules();
            student.Show();
            this.Hide();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            ViewHistory student = new ViewHistory();
            student.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmduser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
