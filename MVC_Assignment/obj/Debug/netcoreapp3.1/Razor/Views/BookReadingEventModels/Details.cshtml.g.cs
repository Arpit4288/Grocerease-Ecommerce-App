#pragma checksum "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "898a7d737ef81027ed1b4b9a72cd74993b4a6fa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookReadingEventModels_Details), @"mvc.1.0.view", @"/Views/BookReadingEventModels/Details.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\_ViewImports.cshtml"
using MVC_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\_ViewImports.cshtml"
using MVC_Assignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898a7d737ef81027ed1b4b9a72cd74993b4a6fa5", @"/Views/BookReadingEventModels/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05e3f456cb7a24d8fc230081490d890f1de6c2e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BookReadingEventModels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Assignment.Models.BookReadingEventModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 43 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
         if (Model.Duration != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 49 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 51 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
         if (Model.Description != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 55 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 58 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 60 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
         if (Model.OtherDetails != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 64 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.OtherDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 67 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
           Write(Html.DisplayFor(model => model.OtherDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 69 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            Total invited to event\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 74 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
             if (Model.InviteByEmail != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
           Write(Model.InviteByEmail.Split(',').Length);

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
                                                      
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
            Write(0);

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
                    
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
#nullable restore
#line 86 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
   await Html.RenderPartialAsync("RenderComments", new CommentModel() { EventId = Model.Id, });

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 89 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\BookReadingEventModels\Details.cshtml"
   await Html.RenderPartialAsync("AddComment", new CommentModel() { EventId = Model.Id, CommentedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value });

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Assignment.Models.BookReadingEventModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
