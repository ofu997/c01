#pragma checksum "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fad8b1465f70c8eb2f0f18f68917357f404200a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Delete), @"mvc.1.0.view", @"/Views/Messages/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Delete.cshtml", typeof(AspNetCore.Views_Messages_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fad8b1465f70c8eb2f0f18f68917357f404200a", @"/Views/Messages/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"852ed4ab724be389f78126bfc8813561574f8c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCwithAuth.Models.Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 27, true);
            WriteLiteral("\r\n<div class=\"plexSerif\">\r\n");
            EndContext();
#line 4 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
      
        ViewData["Title"] = "Delete";
    

#line default
#line hidden
            BeginContext(116, 216, true);
            WriteLiteral("\r\n    <h1>Delete</h1>\r\n\r\n    <h3>Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <hr />\r\n        <dl class=\"row itemsBackground itemsInContainer\">\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(333, 38, false);
#line 15 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(371, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(447, 34, false);
#line 18 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(481, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(564, 42, false);
#line 21 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(606, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(682, 38, false);
#line 24 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(720, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(803, 41, false);
#line 27 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(844, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(920, 37, false);
#line 30 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(957, 74, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1032, 40, false);
#line 33 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1148, 36, false);
#line 36 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1267, 45, false);
#line 39 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1388, 41, false);
#line 42 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1512, 40, false);
#line 45 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1628, 36, false);
#line 48 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1747, 40, false);
#line 51 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1863, 36, false);
#line 54 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1899, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1982, 43, false);
#line 57 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2101, 39, false);
#line 60 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(2140, 74, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2215, 45, false);
#line 63 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2260, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2336, 15, false);
#line 66 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Model.TimeStamp);

#line default
#line hidden
            EndContext();
            BeginContext(2351, 74, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2426, 45, false);
#line 69 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.userEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2471, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2547, 41, false);
#line 72 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.userEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2588, 62, true);
            WriteLiteral("\r\n            </dd>        \r\n        </dl>\r\n        \r\n        ");
            EndContext();
            BeginContext(2650, 280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fad8b1465f70c8eb2f0f18f68917357f404200a13395", async() => {
                BeginContext(2676, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2690, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fad8b1465f70c8eb2f0f18f68917357f404200a13787", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2726, 142, true);
                WriteLiteral("\r\n            <span class=\"oldFont\"><input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /></span> |\r\n            <span class=\"pmLinks\">");
                EndContext();
                BeginContext(2868, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fad8b1465f70c8eb2f0f18f68917357f404200a15725", async() => {
                    BeginContext(2890, 12, true);
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
                BeginContext(2906, 17, true);
                WriteLiteral("</span>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2930, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCwithAuth.Models.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
