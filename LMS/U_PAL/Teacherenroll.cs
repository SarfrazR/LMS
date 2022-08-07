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

        private void GridTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Teacher ;");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridTeacher.DataSource = dt;
            GridTeacher.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TeachID = textTid.Text;
            DataAccessLayer.SearchTeacher(TeachID);
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Teacher Where TeacherID = " +TeachID+ ";");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridTeacher.DataSource = dt;
            GridTeacher.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string TeachID = textTid.Text;
            DataAccessLayer.DeleteTeacherRecord(TeachID);
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Teacher ;");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridTeacher.DataSource = dt;
            GridTeacher.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();

        }
    }
}
