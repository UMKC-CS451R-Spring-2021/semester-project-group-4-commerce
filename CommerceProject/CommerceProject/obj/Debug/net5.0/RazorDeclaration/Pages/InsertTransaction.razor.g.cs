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
#line 2 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using CommerceProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/insert")]
    public partial class InsertTransaction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "G:\from documents\School\2021 Spring\451 capstone\Group stuff\Repo\CommerceProject\CommerceProject\Pages\InsertTransaction.razor"
 
    TransactionModel ts = new TransactionModel();
    
    void insertdata()
    {
        _db.InsertTransaction(ts);
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITransactionData _db { get; set; }
    }
}
#pragma warning restore 1591
