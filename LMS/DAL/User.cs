using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    internal class User:Person
    {
        protected string department;
        protected string bloodGroup;
        protected string userType;

        public User(string Fname, string Lname, string Address, string city, string gender, string email, string username, string password,string department, string bloodGroup,string userType) :base(Fname,Lname,Address,city,gender,email,username,password)
        {
            this.department = department;
            this.bloodGroup = bloodGroup;
            this.userType = userType;
        }
    }
}
