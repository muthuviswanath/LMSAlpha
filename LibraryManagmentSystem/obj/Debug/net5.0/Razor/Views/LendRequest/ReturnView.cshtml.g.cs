#pragma checksum "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30e4542b7bf51e8ace4f8e96a9a9b826c9706743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LendRequest_ReturnView), @"mvc.1.0.view", @"/Views/LendRequest/ReturnView.cshtml")]
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
#line 1 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\_ViewImports.cshtml"
using LibraryManagmentSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e4542b7bf51e8ace4f8e96a9a9b826c9706743", @"/Views/LendRequest/ReturnView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ccac7a91f771c7e176f0b33c682a9a11b79105", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LendRequest_ReturnView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryManagmentSystem.Models.LendRequest>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LendRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReturnBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@" <div class=""container"">
  <div class=""row justify-content-md-center""> 
<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-body"">
                  <div class=""row"">
                     <div class=""col"">
                        <center>
                           <h4> Approved Book List </h4>
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
                                <td>Book Name</td>
                                <td>Lend Date</td>
                                <td>Return Date</td>
                             ");
            WriteLiteral("   <td>Status</td>\n                                </tr>\n                            </thead>\n                            <tbody>\n");
#nullable restore
#line 33 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                 foreach (var list in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>");
#nullable restore
#line 36 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                       Write(list.LendId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 37 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                       Write(list.BooksInfo.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 38 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                       Write(list.LendDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 39 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                       Write(list.ReturnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        \n                                        <td>\n");
#nullable restore
#line 42 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                         if(list.LendStatus == "Approved"){
                                           

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30e4542b7bf51e8ace4f8e96a9a9b826c97067437415", async() => {
                WriteLiteral("\n                                            <button>Return Book</button>\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-lendId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                                                                                             WriteLiteral(list.LendId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["lendId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-lendId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["lendId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 47 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                            }
                                            else
                                            {
                                               

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                          Write(list.LendStatus);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                                               
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\n                                     </tr>\n");
#nullable restore
#line 54 "E:\VARSHA KESHAVA PRASAD\WIPRO\VELOCITY\Project\AAAAALMSMoooooooost\LibraryManagmentSystem\Views\LendRequest\ReturnView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \n\n                                     \n                        </tbody>\n                        </table>\n                     </div>\n                  </div>\n        </div>\n    </div>\n</div>\n</div>\n</div>");
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
