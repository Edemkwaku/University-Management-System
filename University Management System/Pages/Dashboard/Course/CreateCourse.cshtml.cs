using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using University_Management_System.Pages.Dashbord.Course;

namespace University_Management_System.Pages.Dashbord
{
    public class CreateCourseModel : PageModel
    {
        public CourseInfo courseInfo = new CourseInfo();
        public string errorMessage="";
        public string successMessage = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            courseInfo.id = Request.Form["course_id"];
            courseInfo.course_name = Request.Form["course_id"];
            courseInfo.duration = int.Parse(Request.Form["duration"]);
            courseInfo.dept = Request.Form["dept"];

            if(courseInfo.id.Length==0 || courseInfo.course_name.Length==0 || courseInfo.dept==null || courseInfo.dept.Length == 0)
            {
                errorMessage = "All fields are Required";
                return;
            }


            try
            {
                string connectionString="server = localhost; port = 3306; username = root; password =; database = schooldb";

                using(MySqlConnection connection=new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO course(course_id,course_name,duration,dept) VALUES(@course_id,@course_name,@duration,@dept)";

                    using(MySqlCommand command=new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@course_id", courseInfo.id);
                        command.Parameters.AddWithValue("@course_name", courseInfo.course_name);
                        command.Parameters.AddWithValue("@duration", courseInfo.duration);
                        command.Parameters.AddWithValue("@dept", courseInfo.dept);

                        command.ExecuteNonQuery();
                    }
                }


            }
            catch(Exception ex)
            {
                errorMessage = ex.Message;
            }

            courseInfo.id = ""; courseInfo.course_name = "";courseInfo.duration =0 ; courseInfo.dept = "";
            successMessage = "Course created successfully";
            Response.Redirect("/Dashboard/Course/Index");
        }
    }
}
