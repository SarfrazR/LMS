using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    internal class classSchedule
    {
        private int classNo;
        private string department;
        private int capacity;
        private int Mul_Quantity; //Number of Multimedia facilities in the classroom
        private string date;
        private string time;
        public classSchedule(int classNo, string dep,int capacity, int M_Q, string date, string time)
        {
           this.classNo = classNo;
            this.time = time;
            this.capacity = capacity;
            this.Mul_Quantity = M_Q;
            this.date = date;
            this.department = dep;
        }
    }
}
