#pragma checksum "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\Pages\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86ffb4adb64a1cf481f3e7c5e7175e4807d02c9c"
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
#line 1 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerce999\CommerceProject\CommerceProject\Pages\RedirectToLogin.razor"
      
    [Parameter] public string Url { get; set; }

    protected override void OnInitialized()
    {
        Navigation.NavigateTo(Url, true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
