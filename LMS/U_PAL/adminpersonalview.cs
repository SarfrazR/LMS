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
    public partial class adminpersonalview : UserControl
    {
        public adminpersonalview()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PAL.Admin ad = new PAL.Admin();
            ad.Show();
            this.Hide();
        }

        private void panelview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void GridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textRegno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
