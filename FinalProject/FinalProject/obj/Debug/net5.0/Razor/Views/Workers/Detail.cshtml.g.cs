#pragma checksum "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Workers\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c648215b77f26ab58a34c62c5aab208eefd5442b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workers_Detail), @"mvc.1.0.view", @"/Views/Workers/Detail.cshtml")]
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
#line 1 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using AmidmedClinic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using AmidmedClinic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using AmidmedClinic.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c648215b77f26ab58a34c62c5aab208eefd5442b", @"/Views/Workers/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5550b41c06bf014853f1c68a104fe8702d74b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Workers_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Workers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit : cover; width: 350px; height: 250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary  btn-sm my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Workers\Detail.cshtml"
   ViewData["Title"] = "Detail"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n\n    <div class=\"col-lg-12 grid-margin stretch-card\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n\n                <div class=\"d-flex justify-content-center\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c648215b77f26ab58a34c62c5aab208eefd5442b5305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 314, "~/images/workers/", 314, 17, true);
#nullable restore
#line 10 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Workers\Detail.cshtml"
AddHtmlAttributeValue("", 331, Model.Image, 331, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\n                <h4> Adı : ");
#nullable restore
#line 11 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Workers\Detail.cshtml"
                      Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                <div> Şöbəsi : ");
#nullable restore
#line 12 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Workers\Detail.cshtml"
                          Write(Model.Positions.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div> Maaşı : ");
#nullable restore
#line 13 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Workers\Detail.cshtml"
                         Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div> Ünvanı : ");
#nullable restore
#line 14 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Workers\Detail.cshtml"
                          Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div> Əlaqə telefonu: ");
#nullable restore
#line 15 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Workers\Detail.cshtml"
                                 Write(Model.Contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n           \n\n\n\n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c648215b77f26ab58a34c62c5aab208eefd5442b8541", async() => {
                WriteLiteral("Geriyə");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Workers> Html { get; private set; }
    }
}
#pragma warning restore 1591
