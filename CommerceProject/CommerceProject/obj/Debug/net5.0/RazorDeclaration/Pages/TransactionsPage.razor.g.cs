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
#line 3 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
using CommerceProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactions")]
    public partial class TransactionsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
       
    private List<PersonModel> people;
    private List<TransactionModel> trans;
    private List<TransactionModel> accountInfo;
    private DisplayTransactionModel newTransaction = new DisplayTransactionModel();
    private string depositValue = "CR";
    private string withdrawalValue = "DR";

    public string UserName;

    protected override async Task OnInitializedAsync()
    {
        UserName = httpContextAccessor.HttpContext.User.Identity.Name; // gets current user's email

        //people = await _db.GetPeople();

        trans = await _trans.GetTransactions(UserName);
        accountInfo = await _trans.GetAccountNum(UserName);
    }

    private async Task InsertTrans()
    {
        DateTime now = DateTime.Now;
        int accNum = accountInfo[0].Account_Num;


        TransactionModel t = new TransactionModel
        {
            Account_Num = accNum,                   // 10010111 for trant@mail.com
            Processing_Date = now,
            Type = chooseType(),
            Amount = roundAmount(),
            Description = newTransaction.Description,
            Balance = newBalance(),
            Location = newTransaction.Location
        };

        await _trans.InsertTransaction(t);              // add to database

        trans.Add(t);                                   // add to list without refreshing page
        newTransaction = new DisplayTransactionModel();     // wipe out form model
    }

    private decimal roundAmount()
    {
        decimal rounded = Math.Round(newTransaction.Amount, 2);
        return rounded;
    }

    private decimal newBalance()              // need to get balance from account? dont include in transaction? set to account
    {
        TransactionModel t = accountInfo[0];


        decimal rounded = Math.Round(newTransaction.Amount, 2);
        return (t.Balance + rounded);
    }

    private string chooseType()
    {


        if (newTransaction.Type == "DR")
        {
            newTransaction.Amount *= -1;
            return "DR";
        }
        else
        {
            return "CR";
        }
    }

    private string getType(string type)
    {
        if (type == "CR")
        {
            return "Credit";
        }
        else
        {
            return "Draft";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITransactionData _trans { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
#pragma warning restore 1591
