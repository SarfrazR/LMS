using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    internal class Person
    {
        protected string FName;
        protected string LName;
        protected string Address;
        protected string City;
        protected string Gender;
        protected string email;
        protected string Username;
        protected string Password;

        public Person(string Fname,string Lname,string Address, string city, string gender,string email,string username,string password)
        {
            this.FName = Fname;
            this.LName = Lname;
            this.Address = Address;
            this.City = city;
            this.Gender = gender;
            this.email = email;
            this.Username = username;
            this.Password = password;
        }
    }
}
