#pragma checksum "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b5dd13dd1016f8473cf2142ec95bd10432de84e"
// <auto-generated/>
#pragma warning disable 1591
namespace CommerceProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceLGS\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    body {
        background-image: url(""/css/images/bgh.png"");
        background-repeat: no-repeat;
        background-position: left bottom;
        min-height: 500px;
        background-attachment: fixed;
    }


    .container-fluid{
        min-width:1016px;
    }

    .container {
        min-width: 400px;
    }

    .list-group-item {
        border: 0 !important;
        padding-top: 2px !important;
        padding-bottom: 2px !important;
    }
</style>


");
            __builder.AddMarkupContent(1, "<div class=\"parent-container d-flex\"><div class=\"row\"><div class=\"col\"><div class=\"card mt-5\"><div class=\"bg-light clearfix\"><div class=\"float-left ml-2\"><h2>\r\n                                Transactions\r\n                            </h2></div>\r\n                        <button type=\"button\" class=\"btn bg-transparent float-right mr-2 mt-1\">Settings <i class=\"fas fa-cog\"></i></button>\r\n                        <button type=\"button\" class=\"btn bg-transparent float-right mr-3 mt-1\">Add Transaction <i class=\"fas fa-plus-circle\"></i></button></div>\r\n                    <div class=\"clearfix\"></div>\r\n                    <div class=\"container-fluid bg-light mb-3 mr-5\" id=\"containerT\"><div id=\"accordion\" role=\"tablist\" aria-multiselectable=\"true\"><div class=\"card\"><div class=\"card-header bg-transparent\" role=\"tab\" id=\"headingOne\" data-toggle=\"collapse\" data-parent=\"#accordion\" data-target=\"#collapseOne\"><a data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapseOne\"><div class=\"float-left\"><h4>LOCATION TEXT</h4></div>\r\n\r\n                                        <div class=\"float-right\"><h4 class=\"text-right\">DATE TEXT</h4></div>\r\n\r\n                                        <div class=\"float\"><h4 class=\"text-center\">PRICE TEXT</h4></div>\r\n\r\n                                        <div class=\"clearfix\"></div></a></div>\r\n\r\n                                <div id=\"collapseOne\" class=\"collapse in\" role=\"tabpanel\" aria-labelledby=\"headingOne\"><div class=\"card-block\">\r\n                                        TEST TEST\r\n                                    </div></div></div>\r\n                            <div class=\"card\"><div class=\"card-header bg-transparent\" role=\"tab\" id=\"headingTwo\" data-toggle=\"collapse\" data-parent=\"#accordion\" data-target=\"#collapseTwo\"><a class=\"collapsed\" data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapseTwo\" aria-expanded=\"false\" aria-controls=\"collapseTwo\"><div class=\"float-left\"><h4>LOCATION TEXT</h4></div>\r\n\r\n                                        <div class=\"float-right\"><h4 class=\"text-right\">DATE TEXT</h4></div>\r\n\r\n                                        <div class=\"float\"><h4 class=\"text-center\">PRICE TEXT</h4></div>\r\n                                        <div class=\"clearfix\"></div></a></div>\r\n                                <div id=\"collapseTwo\" class=\"collapse\" role=\"tabpanel\" aria-labelledby=\"headingTwo\"><div class=\"card-block\">\r\n                                        TEST 1 TEST 2\r\n                                    </div></div></div>\r\n                            <div class=\"card\"><div class=\"card-header bg-transparent\" role=\"tab\" id=\"headingThree\" data-toggle=\"collapse\" data-parent=\"#accordion\" data-target=\"#collapseThree\"><a class=\"collapsed\" data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapseThree\" aria-expanded=\"false\" aria-controls=\"collapseThree\"><div class=\"float-left\"><h4>LOCATION TEXT</h4></div>\r\n\r\n                                        <div class=\"float-right\"><h4 class=\"text-right\">DATE TEXT</h4></div>\r\n\r\n                                        <div class=\"float\"><h4 class=\"text-center\">PRICE TEXT</h4></div>\r\n                                        <div class=\"clearfix\"></div></a></div>\r\n                                <div id=\"collapseThree\" class=\"collapse\" role=\"tabpanel\" aria-labelledby=\"headingThree\"><div class=\"card-block\">\r\n                                        TEST 1 TEST 2\r\n                                    </div></div></div></div></div></div></div></div>\r\n        <div class=\"row\"><div class=\"col\"><div class=\"card ml-2 mt-5\"><div class=\"container bg-light\"><h3> Notifications </h3></div>\r\n                    <ul class=\"list-group\"><li class=\"list-group-item\">Alaska</li>\r\n                        <li class=\"list-group-item\">Spa</li>\r\n                        <li class=\"list-group-item\">2am</li>\r\n                        <li class=\"list-group-item\">ASDSADASAAASDADAD</li></ul></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
