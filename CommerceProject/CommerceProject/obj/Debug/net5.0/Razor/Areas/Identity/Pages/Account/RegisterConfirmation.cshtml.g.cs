#pragma checksum "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b5abdc405ffb75ec53af454b2d73671c468bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\_ViewImports.cshtml"
using CommerceProject.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\_ViewImports.cshtml"
using CommerceProject.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using CommerceProject.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b5abdc405ffb75ec53af454b2d73671c468bdf", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eacf5217b97901224b15731064e3441c3007b57", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08f36f8e8f0f0e78c1a19df215a0f3fb0f85eca5", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Registration confirmed";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h1, h4 {
        font-family: 'Poppins', sans-serif;
    }

    body {
        font-family: 'Open Sans', sans-serif;
        background-image: url(""/css/images/loginhome.jpg"");
        background-size: 100%;
    }

    body {
        background-color: #F7F9FA;
    }

    .logo {
        width: 300px;
    }

    .header-form {
        background-color: #006747;
        height: 50%;
    }

    .no-padding {
        padding-left: 0;
        padding-right: 0;
    }

    .container-fluid {
        max-height: 744.15px;
        max-width: 709.8px;
    }

    .login-custom {
        height: 50px;
        font-family: ""Open Sans"",sans-serif;
        line-height: 1.25;
        text-align: center;
        white-space: nowrap;
        background-color: #007AA3
    }

        .login-custom:focus, .btn:active {
            box-shadow: none;
            outline: 0 !important;
        }

        .login-custom:active:focus {
            background-color: #97C8D9 ");
            WriteLiteral(@"!important;
            border-color: #000000 !important;
            box-shadow: none;
            outline: 0 !important;
        }


        .login-custom:hover {
            background-color: #01506b;
        }

        .login-custom:active, .btn:focus {
            background-color: #97C8D9;
        }
</style>

<div class=""container-fluid bg-white no-padding mt-5"">
    <div style=""height: 19px;"">
        <p class=""header-form"">&nbsp;</p>
    </div>
    <div class=""row justify-content-md-center "">
        <div class=""col-md-11 mt-4 "">
            <div><img class=""logo"" src=""/css/images/test1.png""></div>
            <section class=""mt-4"">
                <div class=""col-md-4"">
                    <h1>");
#nullable restore
#line 81 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h4 style=\"font-weight:bold; color:darkgreen\">Thanks for registering!</h4>\r\n                    <br />\r\n");
#nullable restore
#line 84 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                      
                        if (@Model.DisplayConfirmAccountLink)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>\r\n                                <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 2208, "\"", 2242, 1);
#nullable restore
#line 88 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 2215, Model.EmailConfirmationUrl, 2215, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>Return to login</b></a>\r\n                            </p>\r\n");
#nullable restore
#line 90 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>\r\n                                Please check your email to confirm your account.\r\n                            </p>\r\n");
#nullable restore
#line 96 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercecrunch\CommerceProject\CommerceProject\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                </section>\r\n                <div class=\"col-4 row\">\r\n                    <p>&nbsp;</p>\r\n                </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
