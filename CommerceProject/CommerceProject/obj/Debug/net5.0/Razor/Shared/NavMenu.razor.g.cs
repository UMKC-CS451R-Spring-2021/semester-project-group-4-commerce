#pragma checksum "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f0c64760daeb64d4f21c400e01b3b6b300b56c8"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 5 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Identity.UI.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light");
            __builder.AddAttribute(2, "b-q9fo7l4ayw");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddAttribute(5, "b-q9fo7l4ayw");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" href=\"#\" b-q9fo7l4ayw><img src=\"/css/images/commerce-bank-vector-logo-horizontal.png\" b-q9fo7l4ayw></a>\r\n        ");
            __builder.AddMarkupContent(7, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-q9fo7l4ayw><span class=""navbar-toggler-icon"" b-q9fo7l4ayw></span></button>

        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "collapse navbar-collapse justify-content-end");
            __builder.AddAttribute(10, "id", "navbarNav");
            __builder.AddAttribute(11, "b-q9fo7l4ayw");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "navbar-nav");
            __builder.AddAttribute(14, "b-q9fo7l4ayw");
            __builder.AddMarkupContent(15, "<li class=\"nav-item\" b-q9fo7l4ayw><a class=\"nav-link\" href=\"/home\" b-q9fo7l4ayw>Home <span class=\"sr-only\" b-q9fo7l4ayw>(current)</span></a></li>\r\n\r\n                ");
            __builder.AddMarkupContent(16, "<li class=\"nav-item\" b-q9fo7l4ayw><a class=\"nav-link\" href=\"/transactions\" b-q9fo7l4ayw>Transactions</a></li>\r\n\r\n                ");
            __builder.AddMarkupContent(17, "<li class=\"nav-item\" b-q9fo7l4ayw><a class=\"nav-link\" href=\"/settings\" b-q9fo7l4ayw>Settings</a></li>");
#nullable restore
#line 35 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                 if (unreadNotifications is null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<a class=\"nav-link\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\" b-q9fo7l4ayw><i class=\"fas fa-bell\" b-q9fo7l4ayw></i></a>");
#nullable restore
#line 38 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", "nav-item-notif dropdown mr-3");
            __builder.AddAttribute(21, "b-q9fo7l4ayw");
#nullable restore
#line 43 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                         if (num_unread_notifs == 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<a class=\"nav-link\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\" b-q9fo7l4ayw><i class=\"fas fa-bell\" b-q9fo7l4ayw></i></a>");
#nullable restore
#line 46 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddAttribute(25, "href", "#");
            __builder.AddAttribute(26, "id", "navbarDropdown");
            __builder.AddAttribute(27, "role", "button");
            __builder.AddAttribute(28, "data-toggle", "dropdown");
            __builder.AddAttribute(29, "aria-haspopup", "true");
            __builder.AddAttribute(30, "aria-expanded", "false");
            __builder.AddAttribute(31, "b-q9fo7l4ayw");
            __builder.AddMarkupContent(32, "<i class=\"fas fa-bell\" b-q9fo7l4ayw></i>");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "badge rounded-pill badge-notification bg-danger");
            __builder.AddAttribute(35, "b-q9fo7l4ayw");
            __builder.AddContent(36, 
#nullable restore
#line 49 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                                                                                                                                                                                                                                       num_unread_notifs

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "ul");
            __builder.AddAttribute(38, "class", "dropdown-menu");
            __builder.AddAttribute(39, "b-q9fo7l4ayw");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "head text-white");
            __builder.AddAttribute(42, "b-q9fo7l4ayw");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row");
            __builder.AddAttribute(45, "b-q9fo7l4ayw");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-lg-12 col-sm-12 col-12");
            __builder.AddAttribute(48, "b-q9fo7l4ayw");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "b-q9fo7l4ayw");
            __builder.AddContent(51, "Notifications (");
            __builder.AddContent(52, 
#nullable restore
#line 55 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                                              num_unread_notifs

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                        ");
            __builder.AddMarkupContent(55, "<a href=\"/home\" class=\"float-right text-white\" b-q9fo7l4ayw>View all <i class=\"fas fa-search\" b-q9fo7l4ayw></i></a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                             foreach (var row in unreadNotifications)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "notification-box");
            __builder.AddAttribute(58, "b-q9fo7l4ayw");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "row");
            __builder.AddAttribute(61, "b-q9fo7l4ayw");
            __builder.AddMarkupContent(62, "<div class=\"col-lg-1 col-sm-1 col-1 text-center\" b-q9fo7l4ayw></div>\r\n                                        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-lg-10 col-sm-10 col-10");
            __builder.AddAttribute(65, "b-q9fo7l4ayw");
            __builder.OpenElement(66, "strong");
            __builder.AddAttribute(67, "class", "text-info");
            __builder.AddAttribute(68, "b-q9fo7l4ayw");
            __builder.AddContent(69, 
#nullable restore
#line 67 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                                                       getNotificationType(row)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "b-q9fo7l4ayw");
            __builder.AddContent(73, 
#nullable restore
#line 69 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                                 row.Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                            ");
            __builder.OpenElement(75, "small");
            __builder.AddAttribute(76, "class", "text");
            __builder.AddAttribute(77, "b-q9fo7l4ayw");
            __builder.AddContent(78, 
#nullable restore
#line 71 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                                                 row.Date.ToString("MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(79, ", ");
            __builder.AddContent(80, 
#nullable restore
#line 71 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                                                                                   row.Date.ToString("h:mm tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                    <div class=\"dropdown-divider\" style=\"border-color:grey;\" b-q9fo7l4ayw></div>");
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "li");
            __builder.AddAttribute(83, "class", "footer bg-dark text-center");
            __builder.AddAttribute(84, "b-q9fo7l4ayw");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "class", "text-white");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                                                                     clearNewNotifications

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "b-q9fo7l4ayw");
            __builder.AddContent(89, "Clear");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 82 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.AddMarkupContent(91, "<form method=\"post\" action=\"Identity/Account/LogOut\" b-q9fo7l4ayw><button type=\"submit\" class=\"submit nav-link btn btn-link\" b-q9fo7l4ayw>Sign out</button></form>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\Shelby\Documents\GitHub\semester-project-group-4-commerce\CommerceProject\CommerceProject\Shared\NavMenu.razor"
       
    private List<NotificationListModel> unreadNotifications;
    private List<NotificationParamsModel> notificationSettings;
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

        notificationSettings = await _NotificationList.GetNotificationSettings(UserName);

        if (notificationSettings[0].Send_Email)
        {
            SendEmail(getNotificationType(triggeredNotification), triggeredNotification.Message);
        }

        await InvokeAsync(() =>
        {
            base.StateHasChanged();
        });
    }


    public async void SendEmail(string subject, string message)
    {
        //send notification email
        await _emailSender.SendEmailAsync(
        UserName,
        subject,
        message);
    }


    public string getNotificationType(NotificationListModel notification)
    {
        string not_type = "";

        switch (notification.Notification_Type)
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

    public async void clearNewNotifications()
    {
        foreach (NotificationListModel curr_notification in unreadNotifications)
        {
            await _NotificationList.SetReadToTrue(curr_notification.Notification_ID);
        }

        unreadNotifications = await _NotificationList.GetNotificationsUnread(UserName); // get current user's unread notifs

        num_unread_notifs = unreadNotifications.Count;

        await InvokeAsync(() =>
        {
            base.StateHasChanged();
        });
    }


    public void Dispose()
    {
        this.NotificationService.OnTriggeredNotification -= this.TriggeredNotification;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmailSender _emailSender { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationListData _NotificationList { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TriggeredNotificationBroadcastService NotificationService { get; set; }
    }
}
#pragma warning restore 1591
