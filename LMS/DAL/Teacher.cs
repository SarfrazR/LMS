using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    internal class Teacher:User
    {
        private string teacherID;
        private string qualification;
        private string speciallization;
        private int Salary;

        public Teacher(string Fname, string Lname, string Address, string city, string gender, string email, string username, string password, string department, string bloodGroup, string userType,string teacherID, string qualification,string speciallization,int salary)
            :base(Fname, Lname, Address, city, gender, email, username, password,department,bloodGroup,userType)
        {
            this.teacherID = teacherID;
            this.qualification = qualification;
            this.speciallization = speciallization;
            this.Salary = salary;
        }
    }
}
