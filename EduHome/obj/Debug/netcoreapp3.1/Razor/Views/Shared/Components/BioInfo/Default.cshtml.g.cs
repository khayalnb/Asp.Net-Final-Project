#pragma checksum "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4406dfdfa567f1109397fd2f478db86af2fb59b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BioInfo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BioInfo/Default.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4406dfdfa567f1109397fd2f478db86af2fb59b8", @"/Views/Shared/Components/BioInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05e577a1352695e050b599c28b0dcabd9d842c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BioInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BioInformation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eduhome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"    <div class=""main-footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4 col-sm-6 col-xs-12"">
                    <div class=""single-widget pr-60"">
                        <div class=""footer-logo pb-25"">
                            <a href=""index.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4406dfdfa567f1109397fd2f478db86af2fb59b84048", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 348, "~/img/", 348, 6, true);
#nullable restore
#line 8 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
AddHtmlAttributeValue("", 354, Model.LogoImage, 354, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </div>\r\n                        <p>");
#nullable restore
#line 10 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <div class=\"footer-social\">\r\n                            <ul>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 595, "\"", 621, 1);
#nullable restore
#line 13 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
WriteAttributeValue("", 602, Model.FacebookLink, 602, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 706, "\"", 732, 1);
#nullable restore
#line 14 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
WriteAttributeValue("", 713, Model.PinterstLink, 713, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 818, "\"", 841, 1);
#nullable restore
#line 15 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
WriteAttributeValue("", 825, Model.VimeoLink, 825, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 923, "\"", 948, 1);
#nullable restore
#line 16 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
WriteAttributeValue("", 930, Model.TwitterLink, 930, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>information</h3>
                        <ul>
                            <li><a href=""#"">addmission</a></li>
                            <li><a href=""#"">Academic Calender</a></li>
                            <li><a href=""event.html"">Event List</a></li>
                            <li><a href=""#"">Hostel &amp; Dinning</a></li>
                            <li><a href=""#"">TimeTable</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-2 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>useful links</h3>
                        <ul>
                            <li><a href=""course.html"">our ");
            WriteLiteral(@"courses</a></li>
                            <li><a href=""about.html"">about us</a></li>
                            <li><a href=""teacher.html"">teachers &amp; faculty</a></li>
                            <li><a href=""#"">teams &amp; conditions</a></li>
                            <li><a href=""event.html"">our events</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>get in touch</h3>
                        <p>");
#nullable restore
#line 48 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
                      Write(Html.Raw(Model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 49 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
                      Write(Model.Phone1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <p>");
#nullable restore
#line 50 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
                      Write(Model.Phone2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 51 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
                      Write(Model.EmailAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 52 "C:\Users\ASUS\OneDrive\Desktop\EduHome\EduHome\Views\Shared\Components\BioInfo\Default.cshtml"
                      Write(Model.WebAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BioInformation> Html { get; private set; }
    }
}
#pragma warning restore 1591
