#pragma checksum "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d11cb419ba00eb4ee8e17d0af2fc66de0aee31e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SendMailer_Index), @"mvc.1.0.view", @"/Views/SendMailer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d11cb419ba00eb4ee8e17d0af2fc66de0aee31e", @"/Views/SendMailer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5550b41c06bf014853f1c68a104fe8702d74b0", @"/Views/_ViewImports.cshtml")]
    public class Views_SendMailer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AmidmedClinic.Models.MailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("G??nd??r"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>E-mail sistemi</h2>\r\n<fieldset>\r\n");
#nullable restore
#line 10 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Kimd??n: </p>\r\n        <p>");
#nullable restore
#line 14 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml"
      Write(Html.TextBoxFor(m => m.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Kim??: </p>\r\n        <p>");
#nullable restore
#line 16 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml"
      Write(Html.TextBoxFor(m => m.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Ba??l??q: </p>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml"
      Write(Html.TextBoxFor(m => m.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Mesaj: </p>\r\n        <p>");
#nullable restore
#line 20 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml"
      Write(Html.TextAreaFor(m => m.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d11cb419ba00eb4ee8e17d0af2fc66de0aee31e6750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\SendMailer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</fieldset> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AmidmedClinic.Models.MailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
