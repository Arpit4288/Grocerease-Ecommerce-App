#pragma checksum "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bd94a95b5c4de8ed1b8013ffa73d0aabd350e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_RenderComments), @"mvc.1.0.view", @"/Views/Shared/RenderComments.cshtml")]
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
#line 2 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bd94a95b5c4de8ed1b8013ffa73d0aabd350e26", @"/Views/Shared/RenderComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05e3f456cb7a24d8fc230081490d890f1de6c2e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_RenderComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
 if (((IEnumerable<CommentModel>)ViewBag.comments).Any(comment => comment.EventId == Model.EventId))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Comments</h2>\r\n    <div class=\"comment-container d-flex flex-column flex-grow-1 flex-shrink-1\" style=\"max-height: 220px; overflow-y: auto; margin-bottom: 10px;\">\r\n");
#nullable restore
#line 10 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
         foreach (var comment in ((IEnumerable<CommentModel>)ViewBag.comments).OrderByDescending(x => x.PostedDate))
        {
            var user = await UserManager.FindByIdAsync(comment.CommentedBy);
            var fullName = user.FullName;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
             if (Model.EventId == comment.EventId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card mb-3\">\r\n                    <div class=\"card-body\">\r\n                        <div class=\"d-flex justify-content-between\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
                                              Write(fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <span class=\"text-muted\">");
#nullable restore
#line 20 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
                                                Write(comment.PostedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
                                        Write(comment.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 28 "C:\Users\arpitdhuriya\Desktop\Nagarro\Nagarro Training Assessments Gitlab\MVC_Assignment\MVC_Assignment\Views\Shared\RenderComments.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
