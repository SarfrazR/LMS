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
    public partial class deleteclassschedule : UserControl
    {
        public deleteclassschedule()
        {
            InitializeComponent();
        }

        private void GridClassT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CNum = int.Parse(textCNumber.Text);
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM ClassSchedule where ClassNo = " +CNum+  ";");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridClassT.DataSource = dt;
            GridClassT.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CNum = int.Parse(textCNumber.Text);
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("DELETE * FROM ClassSchedule where ClassNo = " + CNum + ";");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridClassT.DataSource = dt;
            GridClassT.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccessLayer.GetSqlConnection().Open();
            SqlCommand cmd = new SqlCommand("Select * FROM ClassSchedule ;");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            GridClassT.DataSource = dt;
            GridClassT.AllowUserToAddRows = false;
            DataAccessLayer.GetSqlConnection().Close();
        }
    }
}
