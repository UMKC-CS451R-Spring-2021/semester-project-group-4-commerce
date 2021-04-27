// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CommerceProject.Pages
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
#line 11 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
using CommerceProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
using CommerceProject.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
using Microsoft.AspNetCore.Identity.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Homepage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
      
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


    public string user_email;

    protected override void OnInitialized()
    {
        user_email = httpContextAccessor.HttpContext.User.Identity.Name; // gets current user's email

        // Getting current balance of database to be compared to future values
        this.BalanceService.OnBalanceChanged += this.BalanceChanged;
    }


    // Event handler to send notification email
    public void BalanceChanged(object sender, BalanceChangeEventArgs args)
    {
        if (args.NewValue.Balance < 25.00) {
            string subject = "Low Balance Alert";
            string message = "Your bank balance is less than $25.00.";

            SendEmail(subject, message);
        }

    }

    public async void SendEmail(string subject, string message)
    {
        //send notification email
        await _emailSender.SendEmailAsync(
        user_email,
        subject,
        message);
    }

    public void Dispose()
    {
        this.BalanceService.OnBalanceChanged += this.BalanceChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITableChangeBroadcastService BalanceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmailSender _emailSender { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
