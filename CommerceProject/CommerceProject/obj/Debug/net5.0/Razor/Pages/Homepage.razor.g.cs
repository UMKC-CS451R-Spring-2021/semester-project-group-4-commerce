#pragma checksum "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2918c67e4e59e55d527403cc0ebf167820c9217"
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
#line 1 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor"
using CommerceProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor"
using CommerceProject.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor"
using Microsoft.AspNetCore.Identity.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor"
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
            __builder.AddMarkupContent(12, "<h2 b-vbz074av8t> Graph </h2>\r\n            ");
            __builder.OpenComponent<Blazorise.Button>(13);
            __builder.AddAttribute(14, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 40 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor"
                               async () => await MonthHandleRedraw()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(16, "Current Month");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenComponent<Blazorise.Button>(18);
            __builder.AddAttribute(19, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 41 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor"
                               async () => await YearHandleRedraw()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(21, "Current Year");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card mb-3");
            __builder.AddAttribute(25, "style", "border:1px solid #cecece");
            __builder.AddAttribute(26, "b-vbz074av8t");
            __builder.OpenComponent<Blazorise.Charts.LineChart<decimal>>(27);
            __builder.AddComponentReferenceCapture(28, (__value) => {
#nullable restore
#line 43 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor"
                                 lineChart = (Blazorise.Charts.LineChart<decimal>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\khoii\Source\Repos\semester-project-group-4-commercefinal1\CommerceProject\CommerceProject\Pages\Homepage.razor"
      
    LineChart<decimal> lineChart;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await MonthHandleRedraw();
        }
    }

    async Task MonthHandleRedraw()
    {
        await lineChart.Clear();

        await lineChart.AddLabelsDatasetsAndUpdate(getDayLabels(), GetLineChartDataset("month"));
    }

    async Task YearHandleRedraw()
    {
        await lineChart.Clear();

        await lineChart.AddLabelsDatasetsAndUpdate(getMonthLabels(), GetLineChartDataset("year"));
    }

    LineChartDataset<decimal> GetLineChartDataset(string param)
    {
        List<decimal> data = new List<decimal>();
        string label = "";
        int point_radius = 0;

        switch (param)
        {
            case "month":
                label = "Daily Balance";
                data = DailyBalanceData();
                point_radius = 2;
                break;
            case "year":
                label = "Monthly Balance";
                data = MonthlyBalanceData();
                point_radius = 5;
                break;
        }

        return new LineChartDataset<decimal>
        {
            Label = label,
            Data = data,
            BackgroundColor = new List<string> { ChartColor.FromRgba(79, 168, 0, 0.8f) },
            PointBackgroundColor = getPointBackgroundColors(),
            PointBorderColor = getPointBorderColors(),
            Fill = true,
            PointRadius = point_radius,
            BorderDash = new List<int> { }
        };
    }

    List<string> getPointBackgroundColors()
    {
        List<string> pointBackgroundColors = new List<string>();

        for (int i = 0; i < 31; i++)
        {
            pointBackgroundColors.Add(ChartColor.FromRgba(79, 168, 0, 0.8f));
        }

        return pointBackgroundColors;
    }

    List<string> getPointBorderColors()
    {
        List<string> pointBorderColors = new List<string>();

        for (int i = 0; i < 31; i++)
        {
            pointBorderColors.Add(ChartColor.FromRgba(0, 103, 71, 0.8f));
        }

        return pointBorderColors;
    }

    string[] getDayLabels()
    {
        var curr_day = DateTime.Now.Day;
        List<string> dayLabels = new List<string>();

        for (int i = 1; i <= curr_day; i++)
        {
            dayLabels.Add(i.ToString());
        }

        return dayLabels.ToArray();
    }

    string[] getMonthLabels()
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        var curr_month = DateTime.Now.Month;
        List<string> monthLabels = new List<string>();

        for (int i = 1; i <= curr_month; i++)
        {
            monthLabels.Add(months[i - 1]);
        }

        return monthLabels.ToArray();
    }

    List<decimal> MonthlyBalanceData()
    {
        // get dict that contains the avg balance per month of current year
        Dictionary<int, decimal> avg_monthly_balances = new Dictionary<int, decimal>(TransactionData.GetMonthlyBalancesPastYear());

        List<decimal> visual_balances = new List<decimal>();

        for (int i = 0; i < DateTime.Now.Month; i++)
        {
            if (avg_monthly_balances.ContainsKey(i))
            {
                visual_balances.Add(Decimal.Round(avg_monthly_balances[i], 2));
            }
            else
            {
                visual_balances.Add(Decimal.Round(0, 2));
            }
        }

        return visual_balances;
    }

    List<decimal> DailyBalanceData()
    {
        // get dict that contains the avg balance per month of current year
        Dictionary<int, decimal> avg_daily_balances = new Dictionary<int, decimal>(TransactionData.GetDailyBalancesPastMonth(DateTime.Now.Month));

        List<decimal> visual_balances = new List<decimal>();

        for (int i = 0; i < 31; i++)
        {
            if (avg_daily_balances.ContainsKey(i))
            {
                visual_balances.Add(Decimal.Round(avg_daily_balances[i], 2));
            }
            else
            {
                visual_balances.Add(Decimal.Round(0, 2));
            }
        }

        return visual_balances;
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
        if (args.NewValue.Balance < 25.00)
        {
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GetTransactionData TransactionData { get; set; }
    }
}
#pragma warning restore 1591
