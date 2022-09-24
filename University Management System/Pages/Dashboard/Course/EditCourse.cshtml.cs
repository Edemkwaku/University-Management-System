using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace University_Management_System.Pages.Dashbord.Course
{
    public class EditCourseModel : PageModel
    {
        public CourseInfo courseInfo = new CourseInfo();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
            string id = Request.Query["id"];
            try
            {
                string connectionString = "server = localhost; port = 3306; username = root; password =; database = schooldb";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM course WHERE course_id=@course_id";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@course_id", id);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                courseInfo.id = reader.GetString(0);
                                courseInfo.course_name = reader.GetString(1);
                                courseInfo.duration = reader.GetInt32(2);
                                courseInfo.dept = reader.GetString(3);
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }

            

        public void OnPost()
        {
            courseInfo.id = Request.Form["course_id"];
            courseInfo.course_name = Request.Form["course_name"];
            courseInfo.duration = int.Parse(Request.Form["duration"]);
            courseInfo.dept = Request.Form["dept"];

            if (courseInfo.id.Length == 0 || courseInfo.course_name.Length == 0 || courseInfo.dept == null || courseInfo.dept.Length == 0)
            {
                errorMessage = "All fields are Required";
                return;
            }

            try
            {
                string connectionString = "server=localhost;port=3306;username=root;password=;database=schooldb";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE course SET course_name=@course_name,duration=@duration,dept=@dept WHERE course_id = @course_id";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@course_name", courseInfo.course_name);
                        command.Parameters.AddWithValue("@duration", courseInfo.duration);
                        command.Parameters.AddWithValue("@dept", courseInfo.dept);
                        command.Parameters.AddWithValue("@course_id", courseInfo.id);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            Response.Redirect("/Dashboard/Course/Index");
        }
    }
}
