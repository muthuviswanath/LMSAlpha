#pragma checksum "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "900eea1ef6f9efef257d9df76270d61cdef15105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LendRequest_LendRequestById), @"mvc.1.0.view", @"/Views/LendRequest/LendRequestById.cshtml")]
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
#line 1 "E:\LMSAlpha\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using LibraryManagmentSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"900eea1ef6f9efef257d9df76270d61cdef15105", @"/Views/LendRequest/LendRequestById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fc1187f0828b3657e34845ad9b7c89383f04e7c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LendRequest_LendRequestById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryManagmentSystem.Models.LendRequest>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
  
	Layout="_userLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""container"">
  <div class=""row justify-content-md-center""> 
<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-body"">
                  <div class=""row"">
                     <div class=""col"">
                        <center>
                           <h4>User's Requested Book List</h4>
                        </center>
                     </div>
                  </div>
                  <div class=""row"">
                     <div class=""col"">
                        <hr>
                     </div>
                  </div>
                  <div class=""row"">
                     <div class=""col"">
                        <table class=""table table-striped table-bordered"" >
                            <thead>

                                <tr>
                                    <td>Lend Id </td>
                                    <td>User Name </td>
                                    <td>Book Name</td>
                                    <td>");
            WriteLiteral("Status</td>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 36 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                 foreach (var request in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 39 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                       Write(request.LendId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 40 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                       Write(request.AccountsInfo.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 41 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                       Write(request.BooksInfo.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 42 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                       Write(request.LendStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 44 "E:\LMSAlpha\LibraryManagmentSystem\Views\LendRequest\LendRequestById.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                        </table>\r\n                     </div>\r\n                  </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryManagmentSystem.Models.LendRequest>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
