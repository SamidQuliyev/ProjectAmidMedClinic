#pragma checksum "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Kassa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c21a108a886d860618c57d606ae4cd0d11a2c72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kassa_Index), @"mvc.1.0.view", @"/Views/Kassa/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c21a108a886d860618c57d606ae4cd0d11a2c72", @"/Views/Kassa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5550b41c06bf014853f1c68a104fe8702d74b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Kassa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kassa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">

    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""table-responsive"">

                    <div class=""col-md-6 mb-4 stretch-card transparent"">
                        <div class=""card card-dark-blue"">
                            <div class=""card-body"">
                                <p class=""mb-4"">Kassa</p>
                                <p class=""fs-30 mb-2"">");
#nullable restore
#line 13 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Kassa\Index.cshtml"
                                                 Write(Model.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div>\r\n                       Son qeyd edən şəxs ");
#nullable restore
#line 19 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Kassa\Index.cshtml"
                                     Write(Model.LastModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                      Son dəyişmə miqdarı  ");
#nullable restore
#line 22 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Kassa\Index.cshtml"
                                      Write(Model.LastModifiedMoney);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                      Son dəyişmə vaxtı  ");
#nullable restore
#line 25 "C:\Users\user\Downloads\FinalProject3-main\FinalProject3-main\FinalProject\FinalProject\Views\Kassa\Index.cshtml"
                                    Write(Model.LastModifiedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kassa> Html { get; private set; }
    }
}
#pragma warning restore 1591