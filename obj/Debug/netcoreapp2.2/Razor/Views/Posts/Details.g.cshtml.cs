#pragma checksum "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f035f1bb3d352b630fa9f93afac50eb173d18e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Details.cshtml", typeof(AspNetCore.Views_Posts_Details))]
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
#line 1 "/home/oliver/Documents/projects/MVCwithAuth/Views/_ViewImports.cshtml"
using MVCwithAuth;

#line default
#line hidden
#line 2 "/home/oliver/Documents/projects/MVCwithAuth/Views/_ViewImports.cshtml"
using MVCwithAuth.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f035f1bb3d352b630fa9f93afac50eb173d18e4", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"852ed4ab724be389f78126bfc8813561574f8c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCwithAuth.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(32, 27, true);
            WriteLiteral("\r\n<div class=\"plexSerif\">\r\n");
            EndContext();
#line 4 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
      
        ViewData["Title"] = "Details";
    

#line default
#line hidden
            BeginContext(114, 238, true);
            WriteLiteral("\r\n    <h1>Details</h1>\r\n\r\n    <div>\r\n        <h4>Post</h4>\r\n        <hr />\r\n        <div class=\"container postContainer itemsBackground\">        \r\n            <dl class=\"row\">\r\n                <dt class = \"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(353, 41, false);
#line 16 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(394, 87, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(482, 37, false);
#line 19 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(519, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(606, 43, false);
#line 22 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(649, 87, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(737, 39, false);
#line 25 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
               Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(776, 86, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(863, 45, false);
#line 28 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(908, 87, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(996, 15, false);
#line 31 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
               Write(Model.TimeStamp);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 94, true);
            WriteLiteral("\r\n                </dd>        \r\n                <dt class = \"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1106, 45, false);
#line 34 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.userEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 87, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1239, 41, false);
#line 37 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
               Write(Html.DisplayFor(model => model.userEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 100, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n\r\n    <span class=\"pmLinks\">");
            EndContext();
            BeginContext(1380, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f035f1bb3d352b630fa9f93afac50eb173d18e47759", async() => {
                BeginContext(1426, 5, true);
                WriteLiteral("Edit|");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "/home/oliver/Documents/projects/MVCwithAuth/Views/Posts/Details.cshtml"
                                                 WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1435, 35, true);
            WriteLiteral("</span>\r\n    <span class=\"pmLinks\">");
            EndContext();
            BeginContext(1470, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f035f1bb3d352b630fa9f93afac50eb173d18e410089", async() => {
                BeginContext(1492, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1508, 21, true);
            WriteLiteral("</span>\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCwithAuth.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
