// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
using CommerceProject.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
       
    private List<NotificationListModel> unreadNotifications;
    public string UserName;
    public int num_unread_notifs;


    protected override void OnInitialized()
    {
        this.NotificationService.OnTriggeredNotification += this.TriggeredNotification;  //prepare to listen for new notifications

    }


    //populate bell notifications
    protected override async Task OnInitializedAsync()
    {

        UserName = httpContextAccessor.HttpContext.User.Identity.Name; // gets current user's email

        unreadNotifications = await _NotificationList.GetNotificationsUnread(UserName); // get current user's unread notifs

        num_unread_notifs = unreadNotifications.Count;
    }


    public async void TriggeredNotification(NotificationListModel triggeredNotification)
    {
        unreadNotifications = await _NotificationList.GetNotificationsUnread(UserName); // get current user's unread notifs

        num_unread_notifs = unreadNotifications.Count;

        await InvokeAsync(() =>
        {
            base.StateHasChanged();
        });
    }

    public string getNotificationType(NotificationListModel notification)
    {
        string not_type = "";

        switch(notification.Notification_Type)
        {
            case 1:
                not_type = "Timeframe Alert";
                break;
            case 2:
                not_type = "Transaction Alert";
                break;
            case 3:
                not_type = "Low Balance Alert";
                break;
            case 4:
                not_type = "Overdraft Alert";
                break;
        }

        return not_type;
    }


    public void Dispose()
    {
        this.NotificationService.OnTriggeredNotification -= this.TriggeredNotification;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationListData _NotificationList { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TriggeredNotificationBroadcastService NotificationService { get; set; }
    }
}
#pragma warning restore 1591
