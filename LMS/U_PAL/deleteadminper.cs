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
    public partial class deleteadminper : UserControl
    {
        public deleteadminper()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PAL.Admin ad = new PAL.Admin();
            ad.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            DataAccessLayer.DeleteAdminRecord(username);
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Admin ;");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridAdmin.DataSource = dt;
            GridAdmin.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();

        }

        private void GridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Admin ;");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridAdmin.DataSource = dt;
            GridAdmin.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();

        }
    }
}
