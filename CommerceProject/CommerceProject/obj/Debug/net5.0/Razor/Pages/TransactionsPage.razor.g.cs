#pragma checksum "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83d4ad0af997cbe1af230de75907a215ae837fff"
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
#line 3 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
using CommerceProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
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
            __builder.AddMarkupContent(0, @"<style b-9ejtt86256>
    body {
        background-image: url(""/css/images/bgh.png""), url(""/css/images/uprightcv.png"");
        background-repeat: no-repeat;
        background-position: left bottom, right top;
        min-height: 500px;
        background-attachment: fixed;
    }
</style>

");
            __builder.OpenElement(1, "h4");
            __builder.AddAttribute(2, "b-9ejtt86256");
            __builder.AddContent(3, "Current User: ");
            __builder.AddContent(4, 
#nullable restore
#line 22 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                   UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
 if (trans is null)

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                           
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p b-9ejtt86256><em b-9ejtt86256>Loading...</em></p>");
#nullable restore
#line 27 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container mt-3 bg-light");
            __builder.AddAttribute(8, "style", "border:1px solid #cecece");
            __builder.AddAttribute(9, "b-9ejtt86256");
            __builder.AddMarkupContent(10, @"<p class=""h2 mt-2 mb-2"" b-9ejtt86256>
            Transactions
            <button type=""button"" class=""btn btn-info float-right mr-1 btn-info add-new"" data-toggle=""modal"" data-target=""#myModal"" b-9ejtt86256><i class=""fa fa-plus"" b-9ejtt86256></i> Add Transaction </button></p>
        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "myModal");
            __builder.AddAttribute(13, "class", "modal fade");
            __builder.AddAttribute(14, "role", "dialog");
            __builder.AddAttribute(15, "b-9ejtt86256");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(18, "b-9ejtt86256");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-content");
            __builder.AddAttribute(21, "b-9ejtt86256");
            __builder.AddMarkupContent(22, "<div class=\"modal-header\" b-9ejtt86256><h4 class=\"modal-title\" b-9ejtt86256>Add New Transaction</h4>\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" b-9ejtt86256>&times;</button></div>\r\n\r\n                    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "modal-body");
            __builder.AddAttribute(25, "b-9ejtt86256");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form");
            __builder.AddAttribute(28, "b-9ejtt86256");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(29);
            __builder.AddAttribute(30, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 48 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                              newTransaction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 48 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                              InsertTrans

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(33);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddAttribute(39, "b-9ejtt86256");
                __builder2.AddMarkupContent(40, "<label for=\"Amount\" class=\"col-form-label\" b-9ejtt86256>Amount:</label>\r\n                                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "b-9ejtt86256");
                __Blazor.CommerceProject.Pages.TransactionsPage.TypeInference.CreateInputNumber_0(__builder2, 43, 44, "Amount", 45, 
#nullable restore
#line 55 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                              newTransaction.Amount

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTransaction.Amount = __value, newTransaction.Amount)), 47, () => newTransaction.Amount);
                __builder2.AddMarkupContent(48, "\r\n                                        ");
                __Blazor.CommerceProject.Pages.TransactionsPage.TypeInference.CreateInputSelect_1(__builder2, 49, 50, "Type", 51, 
#nullable restore
#line 56 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                            newTransaction.Type

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTransaction.Type = __value, newTransaction.Type)), 53, () => newTransaction.Type, 54, (__builder3) => {
                    __builder3.OpenElement(55, "option");
                    __builder3.AddAttribute(56, "value", 
#nullable restore
#line 57 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                            depositValue

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(57, "b-9ejtt86256");
                    __builder3.AddContent(58, "Deposit");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "                   \r\n                                            ");
                    __builder3.OpenElement(60, "option");
                    __builder3.AddAttribute(61, "value", 
#nullable restore
#line 58 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                            withdrawalValue

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(62, "b-9ejtt86256");
                    __builder3.AddContent(63, "Withdrawal");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n                                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddAttribute(67, "b-9ejtt86256");
                __builder2.AddMarkupContent(68, "<label for=\"Description\" class=\"col-form-label\" b-9ejtt86256>Description:</label>\r\n                                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "b-9ejtt86256");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "id", "Description");
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                                 newTransaction.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTransaction.Description = __value, newTransaction.Description))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTransaction.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddAttribute(79, "b-9ejtt86256");
                __builder2.AddMarkupContent(80, "<label for=\"Location\" class=\"col-form-label\" b-9ejtt86256>Location:</label>\r\n                                    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "b-9ejtt86256");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "id", "Location");
                __builder2.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                              newTransaction.Location

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTransaction.Location = __value, newTransaction.Location))));
                __builder2.AddAttribute(87, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTransaction.Location));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.AddMarkupContent(89, "<div class=\"modal-footer\" b-9ejtt86256><button type=\"submit\" class=\"btn btn-info add-new\" b-9ejtt86256>Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "table-responsive-sm");
            __builder.AddAttribute(93, "b-9ejtt86256");
            __builder.OpenElement(94, "table");
            __builder.AddAttribute(95, "class", "table tableRowHover bg-white");
            __builder.AddAttribute(96, "style", "border-collapse:collapse;");
            __builder.AddAttribute(97, "b-9ejtt86256");
            __builder.AddMarkupContent(98, @"<thead b-9ejtt86256><tr b-9ejtt86256><th b-9ejtt86256>Date</th>
                        <th b-9ejtt86256>Description</th>
                        <th class=""alnright"" b-9ejtt86256>Amount</th>
                        <th class=""alnright"" b-9ejtt86256>Balance</th></tr></thead>
                ");
            __builder.OpenElement(99, "tbody");
            __builder.AddAttribute(100, "b-9ejtt86256");
#nullable restore
#line 99 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                      int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                     foreach (var row in trans)

                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(101, "tr");
            __builder.AddAttribute(102, "data-toggle", "collapse");
            __builder.AddAttribute(103, "data-target", ".data_" + (
#nullable restore
#line 103 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                       i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "b-9ejtt86256");
            __builder.OpenElement(105, "td");
            __builder.AddAttribute(106, "b-9ejtt86256");
            __builder.AddContent(107, 
#nullable restore
#line 104 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                 row.Processing_Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                            ");
            __builder.OpenElement(109, "td");
            __builder.AddAttribute(110, "b-9ejtt86256");
            __builder.AddContent(111, 
#nullable restore
#line 105 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                 row.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                            ");
            __builder.OpenElement(113, "td");
            __builder.AddAttribute(114, "class", "alnright");
            __builder.AddAttribute(115, "b-9ejtt86256");
            __builder.AddContent(116, "$");
            __builder.AddContent(117, 
#nullable restore
#line 106 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                   row.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "class", "alnright");
            __builder.AddAttribute(121, "b-9ejtt86256");
            __builder.AddContent(122, "$");
            __builder.AddContent(123, 
#nullable restore
#line 107 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                    row.Balance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.OpenElement(125, "tr");
            __builder.AddAttribute(126, "class", "tableRowHoverOff noBorder");
            __builder.AddAttribute(127, "b-9ejtt86256");
            __builder.OpenElement(128, "td");
            __builder.AddAttribute(129, "class", "hiddenRow ");
            __builder.AddAttribute(130, "b-9ejtt86256");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "collapse" + " data_" + (
#nullable restore
#line 112 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                           i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(133, "b-9ejtt86256");
            __builder.OpenElement(134, "p");
            __builder.AddAttribute(135, "b-9ejtt86256");
            __builder.AddMarkupContent(136, "<strong b-9ejtt86256>Account # : </strong>");
            __builder.AddContent(137, 
#nullable restore
#line 113 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                      row.Account_Num

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                    ");
            __builder.OpenElement(139, "p");
            __builder.AddAttribute(140, "b-9ejtt86256");
            __builder.AddMarkupContent(141, "<strong b-9ejtt86256>Type : </strong>");
            __builder.AddContent(142, 
#nullable restore
#line 114 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                 row.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                                    ");
            __builder.OpenElement(144, "p");
            __builder.AddAttribute(145, "b-9ejtt86256");
            __builder.AddMarkupContent(146, "<strong b-9ejtt86256>Location : </strong>");
            __builder.AddContent(147, 
#nullable restore
#line 115 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                                                                     row.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 119 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
                        i++;

                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 126 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(148, "    }\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 130 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\TransactionsPage.razor"
       
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
            Processing_Date = now.ToString(),
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




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITransactionData _trans { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
namespace __Blazor.CommerceProject.Pages.TransactionsPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
