using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;


namespace University_Management_System.Pages.Dashboard.Student
{
    public class IndexModel : PageModel
    {
        public List<StudentInfo> listStudents = new List<StudentInfo>();
       
        public void OnGet()
        {
            try
            {
                string connectionString = "server=localhost;port=3306;username=root;password=;database=schooldb";
                using(MySqlConnection connection =new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM student";

                    using(MySqlCommand command =new MySqlCommand(sql, connection))
                    {
                        using(MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StudentInfo studentInfo = new StudentInfo();

                                studentInfo.student_id = reader.GetString(0);
                                studentInfo.fname = reader.GetString(1);
                                studentInfo.lname = reader.GetString(2);
                                studentInfo.DoB = reader.GetDateTime(3).ToString().Substring(0, 9);
                                studentInfo.phone = reader.GetString(4);
                                studentInfo.city = reader.GetString(5);
                                studentInfo.state = reader.GetString(6);
                                studentInfo.digital_add = reader.GetString(7);
                                studentInfo.faculty = reader.GetString(8);
                                studentInfo.hostel = reader.GetString(9);


                                listStudents.Add(studentInfo);
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       
    }

    public class StudentInfo
    {
        
        public string student_id;
        public string fname;
        public string lname;
        public string faculty;
        public string DoB;
        public string city;
        public string state;
        public string digital_add;
        public string phone;
        public string hostel;
    }

    
}
