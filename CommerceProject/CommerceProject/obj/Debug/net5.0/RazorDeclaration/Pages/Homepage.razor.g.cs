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
#line 49 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\Homepage.razor"
      
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
