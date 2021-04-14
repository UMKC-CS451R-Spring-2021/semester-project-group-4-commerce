using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using DataAccessLibrary;
using Microsoft.Extensions.Configuration;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components.Server;
using System.Threading;

namespace CommerceProject.Areas.Identity.Pages.Account
{
    
    public class SendNotificationEmailModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        ClaimsPrincipal current_user;
        IdentityUser iduser;
        String email;
        private readonly IEmailSender _emailSender;
        private readonly ITransactionData db;
        Boolean willSendEmail;
        TransactionModel Most_Recent_Transaction;
        String previous_location;
        ServerAuthenticationStateProvider auth_provider;
     
        public SendNotificationEmailModel(UserManager<IdentityUser> userManager, IEmailSender emailSender, TransactionData _db, ServerAuthenticationStateProvider _auth_provider)
        {
            willSendEmail = false;
            auth_provider = _auth_provider;
            _emailSender = emailSender;
            _userManager = userManager;
            iduser = new IdentityUser(_userManager.GetUserName(current_user));
            current_user = auth_provider.GetAuthenticationStateAsync().Result.User; //get the user who is currently logged in
            String email = _userManager.GetEmailAsync(iduser).Result;
            
            db = _db;
           
            //get location of previous transaction so we can check it against the location of the most recent transaction
            String previous_location = 
                _db.GetTransactions(_userManager.GetUserName(current_user)).Result[_db.GetTransactions(_userManager.GetUserName(current_user)).Result.Count - 2].Location;

            
            TransactionModel Most_Recent_Transaction = 
                _db.GetTransactions(_userManager.GetUserName(current_user)).Result[_db.GetTransactions(_userManager.GetUserName(current_user)).Result.Count - 1];
        }

        public async Task<IActionResult> OnGet()
        {
            
            String message = "No message yet.";
            await _emailSender.SendEmailAsync("cicifire345@gmail.com", message, " you have recieved an email notification!!!");
            Thread.Sleep(300000);
            if (Most_Recent_Transaction.Amount > 1000)
            {
                message = "This email is to inform you that a very large transaction has occurred in your account.";
                willSendEmail = true;
            }

            if(Most_Recent_Transaction.Balance < 100)
            {
                message = "This email is to inform you that your balance is very low.";
                willSendEmail = true;
            }

            if(Most_Recent_Transaction.Location != previous_location)
            {
                message = "This email is to inform you that a transaction has occurred in an abnormal location.";
                willSendEmail = true;
            }

            if(willSendEmail)
            {
               //await _emailSender.SendEmailAsync(email, message,"you have recieved an email notification");
               willSendEmail = false;
            }
            return Page();
        }
    }
}
