#pragma checksum "C:\Users\khoii\Source\Repos\test\CommerceProject\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05aece59e7b654d21cd5dfe402ab600e0f9385e0"
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
#line 1 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using CommerceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using CommerceProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\khoii\Source\Repos\test\CommerceProject\_Imports.razor"
using Blazorise.Material;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-q07gp702ym");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-q07gp702ym");
            __builder.OpenComponent<CommerceProject.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-q07gp702ym");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-q07gp702ym><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-q07gp702ym>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-q07gp702ym");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\khoii\Source\Repos\test\CommerceProject\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
