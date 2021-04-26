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
#nullable restore
#line 3 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\AddTrans.razor"
using CommerceProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\AddTrans.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\AddTrans.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\AddTrans.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addTrans")]
    public partial class AddTrans : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\AddTrans.razor"
       
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
        //float testBal = newTransaction.Amount + accountInfo[0].Balance;

        TransactionModel t = new TransactionModel
        {
            Account_Num = accNum,                   // 10010111 for trant@mail.com
            Processing_Date = now.ToString(),
            Type = chooseType(),
            Amount = roundAmount(),
            Description = newTransaction.Description,
            Balance = newBalance(),
            Location = newTransaction.Location
        };

        await _trans.InsertTransaction(t);              // add to database

        trans.Add(t);                                   // add to list without refreshing page (no longer works data sync issues)
        //trans = await _trans.GetTransactions(UserName);
        newTransaction = new DisplayTransactionModel();     // wipe out form model

    }

    private float roundAmount()
    {
        double rounded = Math.Round(newTransaction.Amount, 2);
        return (float)rounded;
    }

    private float newBalance()              // need to get balance from account? dont include in transaction? set to account
    {
        if (trans.Count != 0)
        {
            double rounded = Math.Round(trans.Last().Balance + newTransaction.Amount, 2);
            return (float)rounded;
        }
        else
        {
            TransactionModel t = accountInfo[0];

            double rounded = Math.Round(newTransaction.Amount + t.Balance, 2);
            return (float)(rounded);
        }
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITransactionData _trans { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
#pragma warning restore 1591
