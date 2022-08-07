using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS.DAL
{
    internal class DataAccessLayer
    {
        public static SqlConnection GetSqlConnection()
        {
            string strConnection = @"Data Source = DESKTOP-58TMAQD ; Initial Catalog = LMS ; Integrated Security = true; ";
            SqlConnection connection = new SqlConnection(strConnection);
            try
            {
                connection.Open();
                MessageBox.Show("Connected to Database successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection Error");
            }


            return connection;
        }

        //CHECK USERNAME AND PASSWORD
        public static SqlDataReader CheckAdmin(string username, string password)
        {
            string qry = "select username, password from Admin where username = " + username + "AND password = " + password + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static SqlDataReader CheckStudent(string username, string password)
        {
            string qry = "select username, password from Student where username = " + username + "AND password = " + password + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static SqlDataReader CheckTeacher(string username, string password)
        {
            string qry = "select username, password from Teacher where username = " + username + "AND password = " + password + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetAdminData()
        {
            string qry = "select * from Admin;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetStudentData()
        {
            string qry = "select * from Student;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetTeacherData()
        {
            string qry = "select * from Teacher;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetCourseData()
        {
            string qry = "select * from Course;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetRule()
        {
            string qry = "select Rules from Announcement;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetNotice()
        {
            string qry = "select Notice from Announcement;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader GetAbout()
        {
            string qry = "select About from Announcement;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static void AddRule(string rule)
        {
            string qry = "insert into Announcement (@Rules);";
            SqlConnection connection = GetSqlConnection();
            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@Rules", rule);
        }

        public static void AddNotice(string notice)
        {
            string qry = "insert into Announcement (@Notice);";
            SqlConnection connection = GetSqlConnection();
            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@Notice", notice);
        }

        public static void AddAbout(string about)
        {
            string qry = "insert into Announcement (@About);";
            SqlConnection connection = GetSqlConnection();
            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@About", about);
        }

        public static void AddAdminRecord(string Fname, string Lname, string address, string city, string gender, string email, string username, string password, string jobScale)
        {
            string qry = "INSERT INTO Admin VALUES (@Fname,@Lname,@Address,@City,@gender,@email,@username,@password,@jobscale);";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Fname", Fname);
            command.Parameters.AddWithValue("@Lname", Lname);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@jobscale", jobScale);
            
            command.ExecuteNonQuery();
        }
            public static void AddClassSchedule(int classNo, string Department, string ClassName,int capacity,int M_Quan,string date, string time)
        {
            string qry = "insert into ClassSchedule(ClassNo,@Department,@ClassName,Capacity,Multi_Quantity,Date, Time)";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("ClassNo", classNo);
            command.Parameters.AddWithValue("@Department", Department);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("Capacity",capacity );
            command.Parameters.AddWithValue("Multi_Quantity", M_Quan);
            command.Parameters.AddWithValue("Date", date);
            command.Parameters.AddWithValue("Time", time);
            command.ExecuteNonQuery();
        }

        public static void AddCourseResult(string courseID, string TeacherID, string RegNo, string grade, int marks, float GPA)
        {
            string qry = "insert into Result values (@CourseID,@TeacherID,@RegNo,@Grade,marks,GPA)";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@CourseID", courseID);
            command.Parameters.AddWithValue("@TeacherID", TeacherID);
            command.Parameters.AddWithValue("@RegNo", RegNo);
            command.Parameters.AddWithValue("@Grade", grade);
            command.Parameters.AddWithValue("marks", marks);
            command.Parameters.AddWithValue("GPA", GPA);
            command.ExecuteNonQuery();
        }
        public static void AddCourseRecord(string courseID, string courseTitle, string totalReg, string offerSemester)
        {
            string qry = "insert into Course Values(@CourseID,@CourseTitle,@TotalReg,@OfferSemester)";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@CourseID", courseID);
            command.Parameters.AddWithValue("@CourseTitle", courseTitle);
            command.Parameters.AddWithValue("@TotalReg", totalReg);
            command.Parameters.AddWithValue("@OfferSemester", offerSemester);
            command.ExecuteNonQuery();
        }
        public static void AddTeacherRecord(string teacherID,string password, string Fname, string Lname, string address,string city,string gender, string email,string username,string speciallization, string department,string bloodgroup,int salary,string H_Qual)
        {
            string qry = "insert into Teacher values(@Fname,@Lname,@Address,@City,@gender,@email,@username,@password,@department,@department,@bloodgroup,@TeacherID,@Qualification,@Speciallization,Salary);";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Fname", Fname);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@Lname", Lname);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@department", department);
            command.Parameters.AddWithValue("@bloodgroup", bloodgroup);
            command.Parameters.AddWithValue("@TeacherID", teacherID);
            command.Parameters.AddWithValue("@Qualification", H_Qual);
            command.Parameters.AddWithValue("@Speciallization",speciallization );
            command.Parameters.AddWithValue("Salary", salary);
            command.ExecuteNonQuery();
        }


        public static void AddStudentRecord(string RegNo, string password, string Fname, string Lname, string address, string city, string gender, string email, string username, string GRelation, string department, string bloodgroup, int fee, string semester, string Gname, string gPhone)
        {
            string qry = "insert into Student values(@Fname,@Lname,@Address,@City,@gender,@email,@username,@password,@department,@bloodgroup,@RegNo,@Fee,@GName,@GPhone,@GRelation,@Semester)";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Fname", Fname);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@Lname", Lname);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@department", department);
            command.Parameters.AddWithValue("@bloodgroup", bloodgroup);
            command.Parameters.AddWithValue("@RegNo", RegNo);
            command.Parameters.AddWithValue("@GName", Gname);
            command.Parameters.AddWithValue("@Semester", semester);
            command.Parameters.AddWithValue("Fee", fee);
            command.Parameters.AddWithValue("@GRelation", GRelation);
            command.Parameters.AddWithValue("@GPhone", gPhone);
            command.ExecuteNonQuery();
        }
        
        public static DataSet GetDataThroughDataAdapter() //Disconnected Layer
        {
            string qry = "SELECT* FROM Courses;";
            SqlConnection conn = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, conn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Courses");
            return ds;
        }

        // SEARCH

        public static SqlDataReader SearchAdmin(string username)
        {
            string qry = "select * from Admin where username = " + username + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader SearchCourse(string CourseID)
        {
            string qry = "select * from Courses where CourseID = " + CourseID + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader SearchTeacher(string TeacherID)
        {
            string qry = "select * from Teacher where TeacherID = " + TeacherID + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader SearchStudent(string RegNo)
        {
            string qry = "select * from Student where RegNo = " + RegNo + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static SqlDataReader SearchClassSchedule(int classNo)
        {
            string qry = "select * from ClassSchedule where ClassNo = " + classNo + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        // UPDATE


        public static void UpdateAdminRecord(string password, string Fname, string Lname, string address, string city, string gender, string email, string username, int jobScale)
        {
            string qry = "Update Teacher set Fname=@Fname,Lname=@Lname,Address=@Address,City=@City,gender=@gender,email=@email,username=@username,password=@password,jobscale=jobscale where username=@username;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Fname", Fname);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@Lname", Lname);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@jobscale", jobScale);
            command.ExecuteNonQuery();
        }
        public static void UpdateCourseRecord(string courseID, string courseTitle, string totalReg, string offerSem)
        {
            string qry = "update Course set CourseID = @CourseID, CourseTitle = @CourseTitle , TotalReg =@TotalReg , OfferSemester =@OfferSemester where CourseID = @CourseID;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@CourseID", courseID);
            command.Parameters.AddWithValue("@CourseTitle", courseTitle);
            command.Parameters.AddWithValue("@TotalReg", totalReg);
            command.Parameters.AddWithValue("@OfferSemester", offerSem);
            command.ExecuteNonQuery();
        }

        public static void UpdateClassSchedule(int classNo, string Department, string ClassName, int capacity, int M_Quan, string date, string time)
        {
            string qry = "Update ClassSchedule set ClassNo=ClassNo,Department=@Department,ClassName=@ClassName,Capacity=Capacity,Multi_Quantity=Multi_Quantity,Date=Date, Time=Time where ClassNo=ClassNo)";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("ClassName", classNo);
            command.Parameters.AddWithValue("@Department", Department);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("Capacity", capacity);
            command.Parameters.AddWithValue("Multi_Quantity", M_Quan);
            command.Parameters.AddWithValue("Date", date);
            command.Parameters.AddWithValue("Time", time);
            command.ExecuteNonQuery();
        }

        public static void UpdateCourseResult( string RegNo, string grade, int marks, float GPA)
        {
            string qry = "Update Result set Grade=@Grade,marks=marks,GPA=GPA  where RegNo = @RegNo)";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Grade", grade);
            command.Parameters.AddWithValue("marks", marks);
            command.Parameters.AddWithValue("GPA", GPA);
            command.ExecuteNonQuery();
        }

        public static void UpdateTeacherRecord(string teacherID,string password, string Fname, string Lname, string address, string city, string gender, string email, string username, string speciallization, string department, string bloodgroup, int salary, string H_Qual)
        {
            string qry = "update Teacher set Fname = @Fname, Lname = @Lname, Address = @Address, City = @City, gender = @gender, email = @email, username = @username, password = @password, speciallization  = @speciallization, department = @department, bloodgroup = @bloodgroup, Salary = Salary,Qualification = @Qualification where TeacherID = @TeacherID;";
                SqlConnection connection = GetSqlConnection();
                SqlCommand command = new SqlCommand(qry, connection);
                command.Parameters.AddWithValue("@Fname", Fname);
            command.Parameters.AddWithValue("@Lname", Lname);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@department", department);
                command.Parameters.AddWithValue("@bloodgroup", bloodgroup);
                command.Parameters.AddWithValue("@TeacherID", teacherID);
                command.Parameters.AddWithValue("@Qualification", H_Qual);
                command.Parameters.AddWithValue("@Speciallization", speciallization);
                command.Parameters.AddWithValue("Salary", salary);
                command.ExecuteNonQuery();
        }
        public static void UpdateStudentRecord(string RegNo, string password, string Fname, string Lname, string address, string city, string gender, string email, string username, string GRelation, string department, string bloodgroup, int fee, string semester,string Gname,string gPhone)
        {
            string qry = "update Student set Fname = @Fname, Lname = @Lname, Address = @Address, City = @City, gender = @gender, email = @email, username = @username, password = @password, GRelation = @Grelation, GPhone  = @GPhone, department = @department, bloodgroup = @bloodgroup, Fee = Fee,GPhone = @GPhone, GName = @GName where RegNo = @RegNo;";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Fname", Fname);
            command.Parameters.AddWithValue("@Lname", Lname);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@department", department);
            command.Parameters.AddWithValue("@bloodgroup", bloodgroup);
            command.Parameters.AddWithValue("@RegNo", RegNo);
            command.Parameters.AddWithValue("@GName", Gname);
            command.Parameters.AddWithValue("@GPhone", gPhone);
            command.Parameters.AddWithValue("@GRelation", GRelation);
            command.Parameters.AddWithValue("Semester", semester);
            command.Parameters.AddWithValue("Fee", fee);
            command.ExecuteNonQuery();
        }




        // DELETE

        public static void DeleteAdminRecord(string username)
        {
            string qry = "delete from Admin where  = " + username + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }

        public static void DeleteCourseRecord(string CourseID)
        {
            string qry = "delete from Course where CourseID = " + CourseID + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }

        public static void DeleteTeacherRecord(string TeacherID)
        {
            string qry = "delete from Teacher where TeacherID = " + TeacherID + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }
        public static void DeleteStudentRecord(string RegNo)
        {
            string qry = "delete from Student where RegNo = " + RegNo + ";";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
        }
        public static void AddCourseAssign(string Sid, string Tid, int Marks)
        {
            string qry = @"Insert into Result values("+Sid+","+Tid+","+Marks+") where "+Sid+".Result = "+Sid+".Course AND "+Tid+".Result = "+Tid+".Teacher; ";
            SqlConnection connection = GetSqlConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@CourseID", Sid);
            command.Parameters.AddWithValue("@TeacherID", Tid);
            command.Parameters.AddWithValue("Marks", Marks);
            command.ExecuteNonQuery();
        }
        }
    }
