#pragma checksum "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2defc724d596f35ebebe93f624c4fcca0246c290"
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
#line 1 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Homepage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style b-vbz074av8t>
    body {
        background-image: url(""/css/images/bgh.png""), url(""/css/images/uprightcv.png"");
        background-repeat: no-repeat;
        background-position: left bottom, right top;
        min-height: 500px;
        background-attachment: fixed;
    }


</style>

    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mt-3");
            __builder.AddAttribute(3, "b-vbz074av8t");
            __builder.AddMarkupContent(4, @"<div class=""col-sm-8"" b-vbz074av8t><div class=""container mt-1 bg-light float-left"" style=""border:1px solid #cecece"" b-vbz074av8t><h2 b-vbz074av8t>
                    Dashboard
                </h2>
                This is where triggered notifications go
                <p class=""text-right"" b-vbz074av8t>Export to spreadsheet goes here</p></div></div>
        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-4");
            __builder.AddAttribute(7, "b-vbz074av8t");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container bg-light sticky-top mt-1");
            __builder.AddAttribute(10, "style", "border:1px solid #cecece");
            __builder.AddAttribute(11, "b-vbz074av8t");
            __builder.AddMarkupContent(12, "<h2 b-vbz074av8t> Graph </h2>\r\n                ");
            __builder.OpenComponent<Blazorise.Button>(13);
            __builder.AddAttribute(14, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 29 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
                                   async () => await HandleRedraw()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(16, "Past Month");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenComponent<Blazorise.Button>(18);
            __builder.AddAttribute(19, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 30 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
                                   async () => await HandleRedraw()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(21, "Past Year");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n                ");
            __builder.OpenComponent<Blazorise.Charts.LineChart<double>>(23);
            __builder.AddComponentReferenceCapture(24, (__value) => {
#nullable restore
#line 32 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
                                 lineChart = (Blazorise.Charts.LineChart<double>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
          
        LineChart<double> lineChart;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await HandleRedraw();
            }
        }

        async Task HandleRedraw()
        {
            await lineChart.Clear();

            await lineChart.AddLabelsDatasetsAndUpdate(Labels, GetLineChartDataset());
        }

        LineChartDataset<double> GetLineChartDataset()
        {
            return new LineChartDataset<double>
            {
                Label = "# of randoms",
                Data = RandomizeData(),
                BackgroundColor = backgroundColors,
                BorderColor = borderColors,
                Fill = true,
                PointRadius = 2,
                BorderDash = new List<int> { }
            };
        }

        string[] Labels = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        List<string> backgroundColors = new List<string> { ChartColor.FromRgba(255, 99, 132, 0.2f), ChartColor.FromRgba(54, 162, 235, 0.2f), ChartColor.FromRgba(255, 206, 86, 0.2f), ChartColor.FromRgba(75, 192, 192, 0.2f), ChartColor.FromRgba(153, 102, 255, 0.2f), ChartColor.FromRgba(255, 159, 64, 0.2f) };
        List<string> borderColors = new List<string> { ChartColor.FromRgba(255, 99, 132, 1f), ChartColor.FromRgba(54, 162, 235, 1f), ChartColor.FromRgba(255, 206, 86, 1f), ChartColor.FromRgba(75, 192, 192, 1f), ChartColor.FromRgba(153, 102, 255, 1f), ChartColor.FromRgba(255, 159, 64, 1f) };

        List<double> RandomizeData()
        {
            var r = new Random(DateTime.Now.Millisecond);

            return new List<double> { r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble(), r.Next(3, 50) * r.NextDouble() };
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
