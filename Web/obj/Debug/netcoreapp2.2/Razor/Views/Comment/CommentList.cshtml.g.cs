#pragma checksum "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46d5d44e97014929493c25f82e420d12bc8503f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_CommentList), @"mvc.1.0.view", @"/Views/Comment/CommentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comment/CommentList.cshtml", typeof(AspNetCore.Views_Comment_CommentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d5d44e97014929493c25f82e420d12bc8503f0", @"/Views/Comment/CommentList.cshtml")]
    public class Views_Comment_CommentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/base.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/sub.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
  
    ViewBag.Title = "CommentList";
    Layout = null;

#line default
#line hidden
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(95, 73, true);
            WriteLiteral("\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n");
            EndContext();
            BeginContext(168, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46d5d44e97014929493c25f82e420d12bc8503f04650", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(237, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(239, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46d5d44e97014929493c25f82e420d12bc8503f05985", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(307, 1054, true);
            WriteLiteral(@"

<div id=""content"">
    <div class=""tb1"">
        <table class=""niunantab"">
            <tbody>
                <tr>
                    <th style=""font-family: 'Times New Roman';"">
                        Module
                    </th>
                    <th style=""font-family: 'Times New Roman';"">
                        ID
                    </th>
                    <th style=""font-family: 'Times New Roman';"">
                        User
                    </th>
                    <th style=""font-family: 'Times New Roman';"">
                        Time
                    </th>
                    <th style=""font-family: 'Times New Roman';"">
                        Score
                    </th>
                    <th style=""font-family: 'Times New Roman';"">
                        Comment
                    </th>
                    
                    <th style=""width: 160px; font-family: 'Times New Roman';"">
                        Operation
                    ");
            WriteLiteral("</th>\r\n                </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                 foreach (System.Data.DataRow dr in Model.Rows)
                {

#line default
#line hidden
            BeginContext(1445, 112, true);
            WriteLiteral("                    <tr>\r\n                        <td style=\"text-align: center;\">\r\n                            ");
            EndContext();
            BeginContext(1558, 12, false);
#line 44 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                       Write(dr["moduel"]);

#line default
#line hidden
            EndContext();
            BeginContext(1570, 119, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align: center;\">\r\n                            ");
            EndContext();
            BeginContext(1690, 9, false);
#line 47 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                       Write(dr["mid"]);

#line default
#line hidden
            EndContext();
            BeginContext(1699, 119, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align: center;\">\r\n                            ");
            EndContext();
            BeginContext(1819, 12, false);
#line 50 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                       Write(dr["userid"]);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 119, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align: center;\">\r\n                            ");
            EndContext();
            BeginContext(1951, 13, false);
#line 53 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                       Write(dr["thedate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1964, 119, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align: center;\">\r\n                            ");
            EndContext();
            BeginContext(2084, 14, false);
#line 56 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                       Write(dr["thescore"]);

#line default
#line hidden
            EndContext();
            BeginContext(2098, 119, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align: center;\">\r\n                            ");
            EndContext();
            BeginContext(2218, 12, false);
#line 59 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                       Write(dr["thecon"]);

#line default
#line hidden
            EndContext();
            BeginContext(2230, 145, true);
            WriteLiteral("\r\n                        </td>\r\n                        \r\n                        <td style=\"text-align: center;\">\r\n                            ");
            EndContext();
            BeginContext(2376, 62, false);
#line 63 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                       Write(Html.ActionLink("Edit", "CommentEdit", new { id = @dr["id"] }));

#line default
#line hidden
            EndContext();
            BeginContext(2438, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2469, 66, false);
#line 64 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                       Write(Html.ActionLink("Delete", "CommentDelete", new { id = @dr["id"] }));

#line default
#line hidden
            EndContext();
            BeginContext(2535, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Comment\CommentList.cshtml"
                }

#line default
#line hidden
            BeginContext(2614, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
