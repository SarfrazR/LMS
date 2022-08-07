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
    public partial class StudentPersonal : UserControl
    {
        public StudentPersonal()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void GridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Student where Username ;");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridStud.DataSource = dt;
            GridStud.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();
        }
    }
}
