using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    internal class Student:User
    {
        private string regNo; //Registration Number
        private int Fee;
        private string guardianName;
        private string guardianPhone;
        private string guardianRelation;
        private int semester;

        public Student(string Fname, string Lname, string Address, string city, string gender, string email, string username, string password, string department, string bloodGroup, string userType, string teacherID, string qualification, string speciallization, int salary,string regNo, int fee,string guardianName,string guardianPhone,string guardianRelation,int semester)
            :base(Fname, Lname, Address, city, gender, email, username, password, department, bloodGroup, userType)
        {
            this.regNo = regNo;
            this.Fee = fee;
            this.guardianName = guardianName;
            this.guardianPhone = guardianPhone;
            this.guardianRelation = guardianRelation;
            this.semester = semester;
            
        }
    }
}
