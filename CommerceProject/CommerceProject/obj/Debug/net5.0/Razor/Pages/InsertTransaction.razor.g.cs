#pragma checksum "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af22ae09bea02951c4cbe90c4c1c4f5f8a19dca"
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
#line 2 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using CommerceProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using CommerceProject.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/insert")]
    public partial class InsertTransaction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Insert new transaction</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
                  newTransaction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
                                                  InsertTrans

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __Blazor.CommerceProject.Pages.InsertTransaction.TypeInference.CreateInputNumber_0(__builder2, 9, 10, "Amount", 11, 
#nullable restore
#line 19 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
                                          newTransaction.Amount

#line default
#line hidden
#nullable disable
                , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTransaction.Amount = __value, newTransaction.Amount)), 13, () => newTransaction.Amount);
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.AddMarkupContent(15, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Owner\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
 
    private DisplayTransactionModel newTransaction = new DisplayTransactionModel();

    //private TransactionModel ts = new TransactionModel();

    //private void insertdata()
    //{
    //    _db.InsertTransaction(ts);

    //}

    private async Task InsertTrans()
    {
        TransactionModel t = new TransactionModel
        {
            Amount = newTransaction.Amount
        };

        await _db.InsertPerson(t);

        newTransaction = new DisplayTransactionModel();     // wipe out form model
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITransactionData _db { get; set; }
    }
}
namespace __Blazor.CommerceProject.Pages.InsertTransaction
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
    }
}
#pragma warning restore 1591
