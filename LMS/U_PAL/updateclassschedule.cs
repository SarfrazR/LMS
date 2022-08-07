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
    public partial class updateclassschedule : UserControl
    {
        public updateclassschedule()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ClassNo = int.Parse(textCNumber.Text);
            string Depart = textDepart.Text;
            string cName = textCName.Text;
            int Capacity = int.Parse(textCCapacity.Text);
            int MQuan = int.Parse(comboMultiMedia.Text);
            string Date = TimePickerClass.ToString();
            string time = string.Empty;
            DataAccessLayer.UpdateClassSchedule(ClassNo, Depart, cName, Capacity, MQuan, Date, time);
        }

        private void updateclassschedule_Load(object sender, EventArgs e)
        {

        }
    }
}
