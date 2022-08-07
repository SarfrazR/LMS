using LMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.U_PAL
{
    public partial class btnviewcourse : UserControl
    {
        public btnviewcourse()
        {
            InitializeComponent();
            lblSid.Hide();
            lblSid.Hide();
            textSID.Hide();
            
            GridSubject.Hide();
            btnSearchData.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                GridSubject.Show();
                SqlDataReader reader = DataAccessLayer.GetCourseData();
                string result = "";
                while (reader.Read())
                {
                    string course_Id = reader["CourseID"].ToString();
                    string c_Name = reader["CourseTitle"].ToString();
                    string c_Hours = reader["TotalReg"].ToString();
                    string OfferSem = reader["OfferSemester"].ToString();
                    result += string.Format("{0}\t\t{1}\t\t{2}\t\t{3}", course_Id, c_Name, c_Hours, OfferSem);
                    GridSubject.Rows.Add(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblSid.Show();
            lblSid.Show();
            textSID.Show();
           
            GridSubject.Show();
            btnSearch.Hide();
            button4.Hide();
            btnSearchData.Show();
           
        }

        private void btnviewcourse_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchData_Click(object sender, EventArgs e)
        {
            try
            {
                string C_id = textSID.Text;
                SqlDataReader reader = DataAccessLayer.SearchCourse(C_id);
                string result = "";
                while (reader.Read())
                {
                    string course_Id = reader["CourseID"].ToString();
                    string c_Name = reader["CourseTitle"].ToString();
                    string c_Hours = reader["TotalReg"].ToString();
                    string OfferSem = reader["OfferSemester"].ToString();
                    result += string.Format("{0}\t\t{1}\t\t{2}\t\t{3}", course_Id, c_Name, c_Hours, OfferSem);
                    GridSubject.Rows.Add(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void GridSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
