using LMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.U_PAL
{
    public partial class EnrollStudent : UserControl
    {
        public EnrollStudent()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PAL.Admin ad = new PAL.Admin();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Student ;");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridStudent.DataSource = dt;
            GridStudent.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();

        }

        private void GridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnrollStudent_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Sid = textRegno.Text;
            DataAccessLayer.DeleteStudentRecord(Sid);
            SqlCommand cmd = new SqlCommand("Select * FROM Student ;");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridStudent.DataSource = dt;
            GridStudent.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Sid = textRegno.Text;
            DataAccessLayer.SearchStudent(Sid);
            SqlCommand cmd = new SqlCommand("Select * FROM Student Where RegNo =" + Sid+";");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridStudent.DataSource = dt;
            GridStudent.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();
        }
    }
}
