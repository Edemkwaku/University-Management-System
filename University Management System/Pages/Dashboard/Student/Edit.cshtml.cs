using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace University_Management_System.Pages.Dashboard.Student
{
    public class EditModel : PageModel
        
    {
        public StudentInfo studentInfo = new StudentInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
            string id = Request.Query["id"];

            try
            {
                string connectionString = "server=localhost;port=3306;username=root;password=;database=schooldb";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM student WHERE stu_id=@stu_id";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@stu_id", id);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //StudentInfo studentInfo = new StudentInfo();
                               
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

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
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

            if (studentInfo.student_id.Length == 0 || studentInfo.fname.Length == 0 || studentInfo.DoB.Length == 0 || studentInfo.city.Length == 0
                || studentInfo.faculty.Length == 0 || studentInfo.state.Length == 0 || studentInfo.digital_add.Length == 0 || studentInfo.phone.Length == 0
                || studentInfo.hostel.Length == 0)
            {
                errorMessage = "All fields are required";
                return;
            }

            try
            {
                string connectionString = "server=localhost;port=3306;username=root;password=;database=schooldb";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE student SET `fname`=@fname, `lname`=@lname, `DoB`=@DoB, `phone`=@phone,"+
                        "`city`=@city, `state`=@state, `pin_code`=@pin_code, `faculty`=@faculty, `hostel`=@hostel WHERE stu_id=@stu_id;";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@fname", studentInfo.fname);
                        command.Parameters.AddWithValue("@lname", studentInfo.lname);
                        command.Parameters.AddWithValue("@DoB", studentInfo.DoB);
                        command.Parameters.AddWithValue("@phone", studentInfo.phone);
                        command.Parameters.AddWithValue("@city", studentInfo.city);
                        command.Parameters.AddWithValue("@state", studentInfo.state);
                        command.Parameters.AddWithValue("@pin_code", studentInfo.digital_add);
                        command.Parameters.AddWithValue("@faculty", studentInfo.faculty);
                        command.Parameters.AddWithValue("@hostel", studentInfo.hostel);
                        command.Parameters.AddWithValue("@stu_id", studentInfo.student_id);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                return;
            }

            studentInfo.student_id = ""; studentInfo.fname = ""; studentInfo.lname = ""; studentInfo.DoB = ""; studentInfo.phone = ""; studentInfo.city = "";
            studentInfo.state = ""; studentInfo.digital_add = ""; studentInfo.hostel = ""; studentInfo.faculty = "";

            successMessage = "Student Updated Successfully";

            Response.Redirect("/Dashboard/Student/Index");
        }
    }
    }

