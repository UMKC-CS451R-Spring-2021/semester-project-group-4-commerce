#pragma checksum "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f3bc4f4f3a12d2c9800c182aa108e8d7c57150"
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
#line 1 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Bar>(0);
            __builder.AddAttribute(1, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Breakpoint>(
#nullable restore
#line 3 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                 Breakpoint.Desktop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Background", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Background>(
#nullable restore
#line 4 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                 Background.Light

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ThemeContrast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ThemeContrast>(
#nullable restore
#line 5 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                    ThemeContrast.Light

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.BarBrand>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Figure>(7);
                    __builder3.AddAttribute(8, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.FigureSize>(
#nullable restore
#line 7 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                      FigureSize.None

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.FigureImage>(10);
                        __builder4.AddAttribute(11, "Source", "/css/images/commerce-bank-vector-logo-horizontal.jpg");
                        __builder4.AddAttribute(12, "AlternateText", "Commerce Logo");
                        __builder4.AddAttribute(13, "Width", "30%");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.BarMenu>(15);
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.BarStart>(17);
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.BarItem>(19);
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.Button>(21);
                                __builder6.AddAttribute(22, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 13 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                   Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(24, "Log out");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(25, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.Button>(26);
                                __builder6.AddAttribute(27, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 14 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                   Color.Secondary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(29, "Settings");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(30, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.Button>(31);
                                __builder6.AddAttribute(32, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 15 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                   Color.Secondary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(34, "ETC");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
