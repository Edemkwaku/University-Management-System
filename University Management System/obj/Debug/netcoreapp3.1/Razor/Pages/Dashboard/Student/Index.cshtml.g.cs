#pragma checksum "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34b7ff5bf28269c9629f73147beb5bb5109d8733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(University_Management_System.Pages.Dashboard.Student.Pages_Dashboard_Student_Index), @"mvc.1.0.razor-page", @"/Pages/Dashboard/Student/Index.cshtml")]
namespace University_Management_System.Pages.Dashboard.Student
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b7ff5bf28269c9629f73147beb5bb5109d8733", @"/Pages/Dashboard/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f60ee709ff0e44c9c52117f993283098fec061de", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Dashboard_Student_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br />
<div class=""pr-5 pl-5 mr-3 ml-3"">
    <h2>List of Student</h2>
    <a class=""btn btn-primary btn-sm mt-3"" href=""/Dashboard/Student/Create"">New Student</a>
    <table class=""table"">
        <thead>
            <tr>
                
                <th>Index</th>
                <th>FName</th>
                <th>LName</th>
                <th>Birth Date</th>
                <th>Phone</th>
                <th>City</th>
                <th>State</th>
                <th>Zip code</th>
                <th>Faculty</th>
                <th>Hostel</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
             foreach(var student in Model.listStudents)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n             \r\n                <td>");
#nullable restore
#line 32 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.student_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.DoB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.state);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.digital_add);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
               Write(student.hostel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1352, "\"", 1405, 2);
            WriteAttributeValue("", 1359, "/Dashboard/Student/Edit?id=", 1359, 27, true);
#nullable restore
#line 43 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
WriteAttributeValue("", 1386, student.student_id, 1386, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1469, "\"", 1524, 2);
            WriteAttributeValue("", 1476, "/Dashboard/Student/Delete?id=", 1476, 29, true);
#nullable restore
#line 44 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
WriteAttributeValue("", 1505, student.student_id, 1505, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Edem\Desktop\University Management System\University Management System\Pages\Dashboard\Student\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<University_Management_System.Pages.Dashboard.Student.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<University_Management_System.Pages.Dashboard.Student.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<University_Management_System.Pages.Dashboard.Student.IndexModel>)PageContext?.ViewData;
        public University_Management_System.Pages.Dashboard.Student.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
