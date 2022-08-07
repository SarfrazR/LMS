using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    internal class Admin:Person
    {
        private int jobScale;
        Admin(string Fname, string Lname, string Address, string city, string gender, string email, string username, string password,int jobScale) :base(Fname,Lname, Address,city,gender,email,username,password)
        {
            this.jobScale = jobScale;
        }
    }
}
