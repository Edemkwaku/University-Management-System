using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;


namespace University_Management_System.Pages.Dashbord.Course
{
    public class IndexModel : PageModel
    {
        public List<CourseInfo> listCourses = new List<CourseInfo>();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
            try
            {
                string connectionString = "server = localhost; port = 3306; username = root; password =; database = schooldb";
               

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM course";
                    connection.Open();
                    using (MySqlCommand command=new MySqlCommand(sql, connection))
                    {
                        using(MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CourseInfo courseInfo = new CourseInfo();
                                courseInfo.id = reader.GetString(0);
                                courseInfo.course_name = reader.GetString(1);
                                courseInfo.duration = reader.GetInt32(2);
                                courseInfo.dept = reader.GetString(3);

                                listCourses.Add(courseInfo);
                            }
                        }
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
           
        }

       
    }

    public class CourseInfo
    {
        public string id;
        public string course_name;
        public int duration;
        public string dept;
    }
}
