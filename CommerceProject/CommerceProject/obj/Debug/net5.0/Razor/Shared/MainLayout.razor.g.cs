#pragma checksum "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0575929d1ec79d456be45633b4b411c6dc3eda84"
// <auto-generated/>
#pragma warning disable 1591
namespace CommerceProject.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Shared\MainLayout.razor"
using CommerceProject.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "header");
                __builder2.AddAttribute(5, "b-q07gp702ym");
                __builder2.OpenComponent<CommerceProject.Shared.NavMenu>(6);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "main");
                __builder2.AddAttribute(10, "b-q07gp702ym");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "content");
                __builder2.AddAttribute(13, "b-q07gp702ym");
                __builder2.AddContent(14, 
#nullable restore
#line 15 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(15, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<CommerceProject.Pages.RedirectToLogin>(16);
                __builder2.AddAttribute(17, "Url", "Identity/Account/Login");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
