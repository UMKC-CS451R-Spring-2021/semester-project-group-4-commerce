#pragma checksum "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b998bfa210c9a07a3eab42b0234e6cfeac214168"
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
#line 1 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using CommerceProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/settings")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row gutters-sm mt-3");
            __builder.AddAttribute(2, "b-0ixdshmtmn");
            __builder.AddMarkupContent(3, "<div class=\"col-md-2 d-none d-md-block\" b-0ixdshmtmn><div class=\"card\" b-0ixdshmtmn><div class=\"card-body\" b-0ixdshmtmn><nav class=\"nav flex-column nav-pills nav-gap-y-1 green\" b-0ixdshmtmn><a href=\"#profile\" data-toggle=\"tab\" class=\"nav-item nav-link has-icon nav-link-faded active\" b-0ixdshmtmn><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-user mr-2\" b-0ixdshmtmn><path d=\"M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2\" b-0ixdshmtmn></path><circle cx=\"12\" cy=\"7\" r=\"4\" b-0ixdshmtmn></circle></svg>Profile Information\r\n                    </a>\r\n                    <a href=\"#security\" data-toggle=\"tab\" class=\"nav-item nav-link has-icon nav-link-faded\" b-0ixdshmtmn><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-shield mr-2\" b-0ixdshmtmn><path d=\"M12 22s8-4 8-10V5l-8-3-8 3v7c0 6 8 10 8 10z\" b-0ixdshmtmn></path></svg>Security\r\n                    </a>\r\n                    <a href=\"#notification\" data-toggle=\"tab\" class=\"nav-item nav-link has-icon nav-link-faded\" b-0ixdshmtmn><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-bell mr-2\" b-0ixdshmtmn><path d=\"M18 8A6 6 0 0 0 6 8c0 7-3 9-3 9h18s-3-2-3-9\" b-0ixdshmtmn></path><path d=\"M13.73 21a2 2 0 0 1-3.46 0\" b-0ixdshmtmn></path></svg>Notifications\r\n                    </a></nav></div></div></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-9");
            __builder.AddAttribute(6, "b-0ixdshmtmn");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddAttribute(9, "b-0ixdshmtmn");
            __builder.AddMarkupContent(10, "<div class=\"card-header border-bottom mb-3 d-flex d-md-none\" b-0ixdshmtmn><ul class=\"nav nav-tabs card-header-tabs nav-gap-x-1\" role=\"tablist\" b-0ixdshmtmn><li class=\"nav-item\" b-0ixdshmtmn><a href=\"#profile\" data-toggle=\"tab\" class=\"nav-link has-icon active\" b-0ixdshmtmn><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-user\" b-0ixdshmtmn><path d=\"M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2\" b-0ixdshmtmn></path><circle cx=\"12\" cy=\"7\" r=\"4\" b-0ixdshmtmn></circle></svg></a></li>\r\n                    <li class=\"nav-item\" b-0ixdshmtmn><a href=\"#security\" data-toggle=\"tab\" class=\"nav-link has-icon\" b-0ixdshmtmn><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-shield\" b-0ixdshmtmn><path d=\"M12 22s8-4 8-10V5l-8-3-8 3v7c0 6 8 10 8 10z\" b-0ixdshmtmn></path></svg></a></li>\r\n                    <li class=\"nav-item\" b-0ixdshmtmn><a href=\"#notification\" data-toggle=\"tab\" class=\"nav-link has-icon\" b-0ixdshmtmn><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"2\" stroke-linecap=\"round\" stroke-linejoin=\"round\" class=\"feather feather-bell\" b-0ixdshmtmn><path d=\"M18 8A6 6 0 0 0 6 8c0 7-3 9-3 9h18s-3-2-3-9\" b-0ixdshmtmn></path><path d=\"M13.73 21a2 2 0 0 1-3.46 0\" b-0ixdshmtmn></path></svg></a></li></ul></div>\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body tab-content");
            __builder.AddAttribute(13, "b-0ixdshmtmn");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "tab-pane active");
            __builder.AddAttribute(16, "id", "profile");
            __builder.AddAttribute(17, "b-0ixdshmtmn");
            __builder.AddMarkupContent(18, "<h6 b-0ixdshmtmn>PROFILE INFORMATION</h6>\r\n                    <hr b-0ixdshmtmn>\r\n                    ");
            __builder.OpenElement(19, "form");
            __builder.AddAttribute(20, "b-0ixdshmtmn");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddAttribute(23, "b-0ixdshmtmn");
            __builder.AddMarkupContent(24, "<label for=\"firstName\" b-0ixdshmtmn>First Name</label>\r\n                            ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "id", "firstName");
            __builder.AddAttribute(29, "aria-describedby", "firstNameHelp");
            __builder.AddAttribute(30, "placeholder", "Enter your first name");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
                                                                                                                                                                    nametochange.firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nametochange.firstName = __value, nametochange.firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(33, "b-0ixdshmtmn");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.AddAttribute(37, "b-0ixdshmtmn");
            __builder.AddMarkupContent(38, "<label for=\"lastName\" b-0ixdshmtmn>Last Name</label>\r\n                            ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "id", "lastName");
            __builder.AddAttribute(43, "aria-describedby", "lastNameHelp");
            __builder.AddAttribute(44, "placeholder", "Enter your last name");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
                                                                                                                                                                 nametochange.lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nametochange.lastName = __value, nametochange.lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(47, "b-0ixdshmtmn");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "                        \r\n                        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "form-group");
            __builder.AddAttribute(51, "b-0ixdshmtmn");
            __builder.AddMarkupContent(52, "<label for=\"phoneNumber\" b-0ixdshmtmn>Phone Number</label>\r\n                            ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "text");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "id", "phoneNumber");
            __builder.AddAttribute(57, "aria-describedby", "lastNameHelp");
            __builder.AddAttribute(58, "placeholder", "Enter your Phone Number");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
                                                                                                                                                                       nametochange.phoneNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nametochange.phoneNumber = __value, nametochange.phoneNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(61, "b-0ixdshmtmn");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddAttribute(65, "b-0ixdshmtmn");
            __builder.AddMarkupContent(66, "<label for=\"City\" b-0ixdshmtmn>City</label>\r\n                            ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "text");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "id", "City");
            __builder.AddAttribute(71, "placeholder", "Enter your City");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
                                                                                                                        nametochange.city

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nametochange.city = __value, nametochange.city));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(74, "b-0ixdshmtmn");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "form-group");
            __builder.AddAttribute(78, "b-0ixdshmtmn");
            __builder.AddMarkupContent(79, "<label for=\"State\" b-0ixdshmtmn>State</label>\r\n                            ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "text");
            __builder.AddAttribute(82, "class", "form-control");
            __builder.AddAttribute(83, "id", "State");
            __builder.AddAttribute(84, "placeholder", "Enter your State");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
                                                                                                                          nametochange.state

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nametochange.state = __value, nametochange.state));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(87, "b-0ixdshmtmn");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "type", "button");
            __builder.AddAttribute(91, "class", "btn btn-primary");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
                                                                                UpdateInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "b-0ixdshmtmn");
            __builder.AddContent(94, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.AddMarkupContent(96, "<button type=\"reset\" class=\"btn btn-light\" b-0ixdshmtmn>Reset Changes</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n                ");
            __builder.AddMarkupContent(98, "<div class=\"tab-pane\" id=\"security\" b-0ixdshmtmn><h6 b-0ixdshmtmn>SECURITY SETTINGS</h6>\r\n                    <hr class=\"red\" b-0ixdshmtmn>\r\n                    <form b-0ixdshmtmn><div class=\"form-group\" b-0ixdshmtmn><label class=\"d-block\" b-0ixdshmtmn>Change Password</label>\r\n                            <input type=\"text\" class=\"form-control\" placeholder=\"Enter your old password\" b-0ixdshmtmn>\r\n                            <input type=\"text\" class=\"form-control mt-1\" placeholder=\"New password\" b-0ixdshmtmn>\r\n                            <input type=\"text\" class=\"form-control mt-1\" placeholder=\"Confirm new password\" b-0ixdshmtmn></div>\r\n                        <button type=\"button\" class=\"btn btn-primary\" b-0ixdshmtmn>Change password</button></form>\r\n                    <hr b-0ixdshmtmn>\r\n                    <form b-0ixdshmtmn><div class=\"form-group\" b-0ixdshmtmn><label class=\"d-block mb-0\" b-0ixdshmtmn>Security Alerts</label>\r\n                            <div class=\"small text-muted mb-3\" b-0ixdshmtmn>Receive notifications via email</div>\r\n                            <div class=\"custom-control custom-checkbox\" b-0ixdshmtmn><input type=\"checkbox\" class=\"custom-control-input custom-control-input-green\" id=\"customCheck1\" checked b-0ixdshmtmn>\r\n                                <label class=\"custom-control-label\" for=\"customCheck1\" b-0ixdshmtmn>Email each time a notification is triggered</label></div>\r\n                            <div class=\"custom-control custom-checkbox\" b-0ixdshmtmn><input type=\"checkbox\" class=\"custom-control-input custom-control-input-green\" id=\"customCheck2\" checked b-0ixdshmtmn>\r\n                                <label class=\"custom-control-label\" for=\"customCheck2\" b-0ixdshmtmn>Send SMS each time a notification is triggered</label></div></div>\r\n\r\n                        <div class=\"form-group mb-0\" b-0ixdshmtmn><label class=\"d-block\" b-0ixdshmtmn>Notifications</label>\r\n                            <ul class=\"list-group list-group-sm\" b-0ixdshmtmn><li class=\"list-group-item has-icon\" b-0ixdshmtmn>\r\n                                    Time-frame\r\n                                    <div class=\"custom-control custom-control-nolabel custom-switch ml-auto\" b-0ixdshmtmn><input type=\"checkbox\" class=\"custom-control-input\" id=\"customSwitch1\" checked b-0ixdshmtmn>\r\n                                        <label class=\"custom-control-label\" for=\"customSwitch1\" b-0ixdshmtmn></label></div></li>\r\n                                <li class=\"list-group-item has-icon\" b-0ixdshmtmn>\r\n                                    Overdraft\r\n                                    <div class=\"custom-control custom-control-nolabel custom-switch ml-auto\" b-0ixdshmtmn><input type=\"checkbox\" class=\"custom-control-input\" id=\"customSwitch2\" b-0ixdshmtmn>\r\n                                        <label class=\"custom-control-label\" for=\"customSwitch2\" b-0ixdshmtmn></label></div></li>\r\n                                <li class=\"list-group-item has-icon\" b-0ixdshmtmn>\r\n                                    Out of state\r\n                                    <div class=\"custom-control custom-control-nolabel custom-switch ml-auto\" b-0ixdshmtmn><input type=\"checkbox\" class=\"custom-control-input\" id=\"customSwitch3\" checked b-0ixdshmtmn>\r\n                                        <label class=\"custom-control-label\" for=\"customSwitch3\" b-0ixdshmtmn></label></div></li>\r\n                                <li class=\"list-group-item has-icon\" b-0ixdshmtmn>\r\n                                    Test4\r\n                                    <div class=\"custom-control custom-control-nolabel custom-switch ml-auto\" b-0ixdshmtmn><input type=\"checkbox\" class=\"custom-control-input\" id=\"customSwitch4\" checked b-0ixdshmtmn>\r\n                                        <label class=\"custom-control-label\" for=\"customSwitch4\" b-0ixdshmtmn></label></div></li>\r\n                                <li class=\"list-group-item has-icon\" b-0ixdshmtmn>\r\n                                    Test5\r\n                                    <div class=\"custom-control custom-control-nolabel custom-switch ml-auto\" b-0ixdshmtmn><input type=\"checkbox\" class=\"custom-control-input\" id=\"customSwitch5\" b-0ixdshmtmn>\r\n                                        <label class=\"custom-control-label\" for=\"customSwitch5\" b-0ixdshmtmn></label></div></li></ul></div></form></div>\r\n                ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "tab-pane");
            __builder.AddAttribute(101, "id", "notification");
            __builder.AddAttribute(102, "b-0ixdshmtmn");
            __builder.AddMarkupContent(103, "<h6 b-0ixdshmtmn>NOTIFICATION SETTINGS</h6>\r\n                    <hr b-0ixdshmtmn>\r\n                    ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "container");
            __builder.AddAttribute(106, "b-0ixdshmtmn");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "table-wrapper");
            __builder.AddAttribute(109, "b-0ixdshmtmn");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "table-title");
            __builder.AddAttribute(112, "b-0ixdshmtmn");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "row");
            __builder.AddAttribute(115, "b-0ixdshmtmn");
            __builder.AddMarkupContent(116, "<div class=\"col-sm-8\" b-0ixdshmtmn><h2 b-0ixdshmtmn>Notifications List</h2></div>\r\n                                    ");
            __builder.AddMarkupContent(117, @"<div class=""col-sm-4"" b-0ixdshmtmn><button type=""button"" class=""btn btn-info add-new"" data-toggle=""modal"" data-target=""#myModal"" b-0ixdshmtmn><i class=""fa fa-plus"" b-0ixdshmtmn></i>
                                            Add New
                                        </button></div>

                                    ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "id", "myModal");
            __builder.AddAttribute(120, "class", "modal fade");
            __builder.AddAttribute(121, "role", "dialog");
            __builder.AddAttribute(122, "b-0ixdshmtmn");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(125, "b-0ixdshmtmn");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "modal-content");
            __builder.AddAttribute(128, "b-0ixdshmtmn");
            __builder.AddMarkupContent(129, @"<div class=""modal-header"" b-0ixdshmtmn><h4 class=""modal-title"" b-0ixdshmtmn>Add Notification</h4>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" b-0ixdshmtmn>&times;</button></div>
                                                ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "modal-body");
            __builder.AddAttribute(132, "b-0ixdshmtmn");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "form-row");
            __builder.AddAttribute(135, "b-0ixdshmtmn");
            __builder.OpenElement(136, "label");
            __builder.AddAttribute(137, "class", "control-label");
            __builder.AddAttribute(138, "for", "type");
            __builder.AddAttribute(139, "b-0ixdshmtmn");
            __builder.OpenElement(140, "select");
            __builder.AddAttribute(141, "name", "selections");
            __builder.AddAttribute(142, "id", "select");
            __builder.AddAttribute(143, "class", "select form-control");
            __builder.AddAttribute(144, "b-0ixdshmtmn");
            __builder.OpenElement(145, "option");
            __builder.AddAttribute(146, "selected");
            __builder.AddAttribute(147, "b-0ixdshmtmn");
            __builder.AddContent(148, "Choose type");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                                                                ");
            __builder.OpenElement(150, "option");
            __builder.AddAttribute(151, "value", "1");
            __builder.AddAttribute(152, "b-0ixdshmtmn");
            __builder.AddContent(153, "Time");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                                                                ");
            __builder.OpenElement(155, "option");
            __builder.AddAttribute(156, "value", "2");
            __builder.AddAttribute(157, "b-0ixdshmtmn");
            __builder.AddContent(158, "Overdraft");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                                                                ");
            __builder.OpenElement(160, "option");
            __builder.AddAttribute(161, "value", "3");
            __builder.AddAttribute(162, "b-0ixdshmtmn");
            __builder.AddContent(163, "Location");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n\r\n                                                        ");
            __builder.AddMarkupContent(165, "<label class=\"control-label col-md-8\" for=\"size\" b-0ixdshmtmn><input type=\"text\" class=\"form-control ml-3 col-md-8\" id=\"size\" name=\"size\" placeholder=\"Description\" b-0ixdshmtmn></label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                                                    ");
            __builder.AddMarkupContent(167, @"<div class=""modal-footer"" b-0ixdshmtmn><button type=""button"" class=""btn btn-info add-new"" data-dismiss=""modal"" b-0ixdshmtmn>Add</button>
                                                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"" b-0ixdshmtmn>Close</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                            ");
            __builder.AddMarkupContent(169, "<table class=\"table table-bordered\" b-0ixdshmtmn><thead b-0ixdshmtmn><tr b-0ixdshmtmn><th b-0ixdshmtmn>Type</th>\r\n                                        <th b-0ixdshmtmn>Description</th>\r\n                                        <th b-0ixdshmtmn>Actions</th></tr></thead>\r\n                                <tbody b-0ixdshmtmn><tr b-0ixdshmtmn><td b-0ixdshmtmn>Overdraft</td>\r\n                                        <td b-0ixdshmtmn>$1000000000000</td>\r\n                                        <td b-0ixdshmtmn><a class=\"edit\" title=\"Edit\" data-toggle=\"tooltip\" b-0ixdshmtmn><i class=\"fas fa-pen\" b-0ixdshmtmn></i></a>\r\n                                            <a class=\"delete\" title=\"Delete\" data-toggle=\"tooltip\" b-0ixdshmtmn><i class=\"fas fa-trash\" b-0ixdshmtmn></i></a></td></tr>\r\n                                    <tr b-0ixdshmtmn><td b-0ixdshmtmn>Time</td>\r\n                                        <td b-0ixdshmtmn>00:50 - 4:30</td>\r\n                                        <td b-0ixdshmtmn><a class=\"edit\" title=\"Edit\" data-toggle=\"tooltip\" b-0ixdshmtmn><i class=\"fas fa-pen\" b-0ixdshmtmn></i></a>\r\n                                            <a class=\"delete\" title=\"Delete\" data-toggle=\"tooltip\" b-0ixdshmtmn><i class=\"fas fa-trash\" b-0ixdshmtmn></i></a></td></tr>\r\n                                    <tr b-0ixdshmtmn><td b-0ixdshmtmn>Location</td>\r\n                                        <td b-0ixdshmtmn>Topeka, Kansas</td>\r\n                                        <td b-0ixdshmtmn><a class=\"edit\" title=\"Edit\" data-toggle=\"tooltip\" b-0ixdshmtmn><i class=\"fas fa-pen\" b-0ixdshmtmn></i></a>\r\n                                            <a class=\"delete\" title=\"Delete\" data-toggle=\"tooltip\" b-0ixdshmtmn><i class=\"fas fa-trash\" b-0ixdshmtmn></i></a></td></tr></tbody></table>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 239 "C:\Users\khoii\Source\Repos\semester-project-group-4-commerceFINAL3\CommerceProject\CommerceProject\Pages\Settings.razor"
      
    AccountHolderModel nametochange = new AccountHolderModel();
    private string email;
    protected Task UpdateInfo()
    {

        nametochange.email = httpContextAccessor.HttpContext.User.Identity.Name;
        return _acc.ChangeName(nametochange);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountHolderData _acc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
