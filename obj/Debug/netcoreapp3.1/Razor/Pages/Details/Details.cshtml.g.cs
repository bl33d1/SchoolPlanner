#pragma checksum "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b94b13b3108ebac9649d017e6d11c8197d5f8514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SchoolPlanner2.Pages.Details.Pages_Details_Details), @"mvc.1.0.razor-page", @"/Pages/Details/Details.cshtml")]
namespace SchoolPlanner2.Pages.Details
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
#line 1 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\_ViewImports.cshtml"
using SchoolPlanner2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94b13b3108ebac9649d017e6d11c8197d5f8514", @"/Pages/Details/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15862ed59ffcb9c3c02b2703d004528a695f7aeb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Details_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Tasks/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
  
    ViewData["Title"] = "DetailsSubModel";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"subjectName\">");
#nullable restore
#line 8 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                   Write(Model.Subject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<table class=\"table\">\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 14 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
         foreach (var item in Model.Task)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 38 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"taskAndExam\">\r\n    <div class=\"AllTaskDiv\">\r\n        <h4 class=\"tasksOverview\">\r\n            Tasks Overview\r\n        </h4>\r\n        <p class=\"tasksOverview2\">Upcoming</p>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
         foreach (var item in Model.Task)
        {
            if (item.DueDate > DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"singleTaskDiv\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94b13b3108ebac9649d017e6d11c8197d5f85144905", async() => {
                WriteLiteral("<p class=\"taskTitle\">");
#nullable restore
#line 55 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                                  WriteLiteral(item.TaskID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p class=\"taskDetail\">");
#nullable restore
#line 56 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"taskType\">");
#nullable restore
#line 57 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TypeOfTask));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <br />\r\n                    <p class=\"taskSubject\">");
#nullable restore
#line 59 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Subject.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"taskDueDate\">");
#nullable restore
#line 60 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 64 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"tasksOverview2\">Overdue</p>\r\n");
#nullable restore
#line 67 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
         foreach (var item in Model.Task)
        {
            if (item.DueDate < DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"singleTaskDiv\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94b13b3108ebac9649d017e6d11c8197d5f85149421", async() => {
                WriteLiteral("<p class=\"taskTitle\">");
#nullable restore
#line 72 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                                  WriteLiteral(item.TaskID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p class=\"taskDetail\">");
#nullable restore
#line 73 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"taskType\">");
#nullable restore
#line 74 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TypeOfTask));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <br />\r\n                    <p class=\"taskSubject\">");
#nullable restore
#line 76 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Subject.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"taskDueDate\">");
#nullable restore
#line 77 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 81 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"AllExamDiv\">\r\n        <h4 class=\"tasksOverview\">\r\n            Exams Overview\r\n        </h4>\r\n        <p class=\"tasksOverview2\">Upcoming</p>\r\n\r\n\r\n");
#nullable restore
#line 92 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
         foreach (var item in Model.Exam)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"singleExamDiv\">\r\n                <p class=\"examName\">");
#nullable restore
#line 95 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Subject.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Due Date:</p>\r\n                <p class=\"examDate\">");
#nullable restore
#line 97 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DateAndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"examRoom\">");
#nullable restore
#line 98 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 100 "D:\projects\SchoolPlanner\SchoolPlanner2\Pages\Details\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n");
            WriteLiteral(@"

<style>
    .subjectName{
        text-align:center;
    }
    .examName {
        font-size: 20px;
        text-align: center;
    }

    .examDate {
        display: inline-block;
    }

    .examRoom {
        display: inline-block;
        float: right;
    }

    .tasksOverview2 {
        text-align: center;
        font-style: oblique;
    }

    .AllTaskDiv {
        float: left;
        margin-bottom: 120px;
    }

    .AllExamDiv {
        float: right;
    }

    #weekday {
        padding-left: 50px;
        display: inline-block;
        text-align: center
    }

        #weekday th {
            color: darkslateblue
        }

        #weekday td {
            color: black;
            position: inherit;
            font-size: 14px
        }

    .div-orari {
        display: flex;
    }



    .weeklyOverview {
        text-align: center;
        margin-bottom: 50px;
    }

    .tasksOverview {
        text-align: left;
        mar");
            WriteLiteral(@"gin-bottom: 20px;
    }

    .singleTaskDiv {
        width: 300px;
        height: 85px;
        margin-bottom: 40px;
    }

    .singleExamDiv {
        width: 250px;
        height: 85px;
        margin-bottom: 40px;
    }

    .taskTitle {
        display: block;
        text-align: center;
        font-size: 20px;
        color: blue;
        margin-bottom: 0px;
    }

    .taskDetail {
        display: inline-block;
        margin-bottom: 0px;
    }

    .taskType {
        display: inline-block;
        float: right;
        margin-bottom: 0px;
        padding-right: 3px;
        margin-bottom: 20px;
    }

    .taskDueDate {
        display: inline-block;
        margin-bottom: 0px;
    }

    .taskSubject {
        display: inline-block;
        margin-bottom: 0px;
    }

    .taskDetail {
        display: inline-block;
        margin-bottom: 0px;
    }

    .taskDetailLink {
    }
</style>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolPlanner2.Pages.Details.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SchoolPlanner2.Pages.Details.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SchoolPlanner2.Pages.Details.DetailsModel>)PageContext?.ViewData;
        public SchoolPlanner2.Pages.Details.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
