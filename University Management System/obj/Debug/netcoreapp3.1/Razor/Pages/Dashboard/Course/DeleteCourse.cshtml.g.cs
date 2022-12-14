#pragma checksum "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Course\DeleteCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e40f5b6fe858e61f93108f0551708b6480ce2f7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(University_Management_System.Pages.Dashboard.Course.Pages_Dashboard_Course_DeleteCourse), @"mvc.1.0.razor-page", @"/Pages/Dashboard/Course/DeleteCourse.cshtml")]
namespace University_Management_System.Pages.Dashboard.Course
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\_ViewImports.cshtml"
using University_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Course\DeleteCourse.cshtml"
using MySql.Data.MySqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40f5b6fe858e61f93108f0551708b6480ce2f7f", @"/Pages/Dashboard/Course/DeleteCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f60ee709ff0e44c9c52117f993283098fec061de", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Dashboard_Course_DeleteCourse : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Course\DeleteCourse.cshtml"
  

    try
    {
        string id = Request.Query["id"];


        string connectionString = "server=localhost;port=3306;username=root;password=;database=schooldb";
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string sql = "DELETE FROM course WHERE course_id=@course_id";

            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@course_id", id);
                command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


    Response.Redirect("/Dashboard/Course/Index");


#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Dashboard_Course_DeleteCourse> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Dashboard_Course_DeleteCourse> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Dashboard_Course_DeleteCourse>)PageContext?.ViewData;
        public Pages_Dashboard_Course_DeleteCourse Model => ViewData.Model;
    }
}
#pragma warning restore 1591
