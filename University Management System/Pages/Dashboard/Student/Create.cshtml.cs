using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace University_Management_System.Pages.Dashboard.Student
{
    public class CreateModel : PageModel
    {
        public StudentInfo studentInfo =new StudentInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            studentInfo.student_id = Request.Form["student_id"];
            studentInfo.fname = Request.Form["fname"];
            studentInfo.lname = Request.Form["lname"];
            studentInfo.DoB = Request.Form["DoB"];
            studentInfo.city = Request.Form["city"];
            studentInfo.faculty = Request.Form["faculty"];
            studentInfo.state = Request.Form["state"];
            studentInfo.digital_add = Request.Form["digital_add"];
            studentInfo.phone = Request.Form["phone"];
            studentInfo.hostel = Request.Form["hostel"];

            if(studentInfo.student_id.Length==0 || studentInfo.fname.Length==0 || studentInfo.DoB.Length==0 || studentInfo.city.Length==0
                || studentInfo.faculty.Length==0 || studentInfo.state.Length==0 || studentInfo.digital_add.Length==0 || studentInfo.phone.Length==0
                || studentInfo.hostel.Length == 0)
            {
                errorMessage = "All fields are required";
                return;
            }

            try
            {
                string connectionString = "server=localhost;port=3306;username=root;password=;database=schooldb";
                using(MySqlConnection connection=new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO student(`stu_id`, `fname`, `lname`, `DoB`, `phone`, `city`, `state`, `pin_code`, `faculty`, `hostel`)" +
                        "VALUES(@stu_id,@fname,@lname,@DoB,@phone,@city,@state,@pin_code,@faculty,@hostel);";

                    using(MySqlCommand command=new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@stu_id", studentInfo.student_id);
                        command.Parameters.AddWithValue("@fname", studentInfo.fname);
                        command.Parameters.AddWithValue("@lname", studentInfo.lname);
                        command.Parameters.AddWithValue("@DoB", studentInfo.DoB);
                        command.Parameters.AddWithValue("@phone", studentInfo.phone);
                        command.Parameters.AddWithValue("@city", studentInfo.city);
                        command.Parameters.AddWithValue("@state", studentInfo.state);
                        command.Parameters.AddWithValue("@pin_code", studentInfo.digital_add);
                        command.Parameters.AddWithValue("@faculty", studentInfo.faculty);
                        command.Parameters.AddWithValue("@hostel", studentInfo.hostel);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch(Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            studentInfo.student_id = ""; studentInfo.fname = "";studentInfo.lname = "";studentInfo.DoB = "";studentInfo.phone = "";studentInfo.city = "";
            studentInfo.state = "";studentInfo.digital_add = "";studentInfo.hostel = "";studentInfo.faculty = "";

            successMessage = "New Student Added Successfully";

            Response.Redirect("/Dashboard/Student/Index");
        }
    }
}
