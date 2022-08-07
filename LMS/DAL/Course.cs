using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    internal class Course
    {
        private string courseName;
        private string courseID;
        private string totalReg;
        private string offerSemester;

        public Course(string cName,string cID, string tReg, string offSem)
        {
            this.courseName = cName;
            this.courseID = cID;
            this.totalReg = tReg;
            this.offerSemester = offSem;
        }
    }
}
