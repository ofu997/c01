#pragma checksum "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a345c257c002f08653bb0b1bded9bc948d82b8dd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a345c257c002f08653bb0b1bded9bc948d82b8dd", @"/Views/Messages/Delete.cshtml")]
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
            BeginContext(116, 65, true);
            WriteLiteral("\r\n    <h1>Delete</h1>\r\n\r\n    <h3>Are you sure you want to delete ");
            EndContext();
            BeginContext(182, 37, false);
#line 10 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(219, 160, true);
            WriteLiteral("?</h3>\r\n    <div>\r\n        <hr />\r\n        <dl class=\"row containerForPagesExceptIndex itemsBackground \">\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(380, 42, false);
#line 15 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(422, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(498, 38, false);
#line 18 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(536, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(619, 41, false);
#line 21 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(660, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(736, 37, false);
#line 24 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(773, 74, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(848, 40, false);
#line 27 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(888, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(964, 36, false);
#line 30 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1083, 45, false);
#line 33 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1204, 41, false);
#line 36 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1328, 40, false);
#line 39 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1444, 36, false);
#line 42 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1563, 40, false);
#line 45 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1679, 36, false);
#line 48 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 82, true);
            WriteLiteral("\r\n            </dd>        \r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1798, 43, false);
#line 51 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1917, 39, false);
#line 54 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 74, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2031, 45, false);
#line 57 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2152, 15, false);
#line 60 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Model.TimeStamp);

#line default
#line hidden
            EndContext();
            BeginContext(2167, 74, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2242, 45, false);
#line 63 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.userEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 75, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2363, 41, false);
#line 66 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
           Write(Html.DisplayFor(model => model.userEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2404, 62, true);
            WriteLiteral("\r\n            </dd>        \r\n        </dl>\r\n        \r\n        ");
            EndContext();
            BeginContext(2466, 279, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a345c257c002f08653bb0b1bded9bc948d82b8dd12920", async() => {
                BeginContext(2492, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2506, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a345c257c002f08653bb0b1bded9bc948d82b8dd13312", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "/home/oliver/Documents/projects/MVCwithAuth/Views/Messages/Delete.cshtml"
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
                BeginContext(2542, 141, true);
                WriteLiteral("\r\n            <span class=\"oldFont\"><input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /></span> \r\n            <span class=\"pmLinks\">");
                EndContext();
                BeginContext(2683, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a345c257c002f08653bb0b1bded9bc948d82b8dd15249", async() => {
                    BeginContext(2705, 12, true);
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
                BeginContext(2721, 17, true);
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
            BeginContext(2745, 24, true);
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
