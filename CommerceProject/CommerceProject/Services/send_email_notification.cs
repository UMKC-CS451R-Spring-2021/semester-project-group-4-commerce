
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

namespace CommerceProject.Services
{

    public class send_email_notification
    {
        String email;
        private IEmailSender _emailSender;
        TransactionModel Most_Recent_Transaction;
        String previous_location;
        List<TransactionModel> trans_list;
        

        public send_email_notification(IEmailSender emailSender, List<TransactionModel> _trans_list, String _email)
        {
            email = "cicifire345@gmail.com";
            _emailSender = emailSender;
            trans_list = _trans_list;
            Most_Recent_Transaction = trans_list[trans_list.Count - 1];
            previous_location = trans_list[trans_list.Count - 1].Location;
 
        }

        public async void email_notification()
        {

            String message = "No message yet.";
            
            if (Most_Recent_Transaction.Amount > 1000)
            {
                message = "This email is to inform you that a very large transaction has occurred in your account.";

                await _emailSender.SendEmailAsync(email, message, "you have recieved an email notification");
            }

            if (Most_Recent_Transaction.Balance < 100)
            {
                message = "This email is to inform you that your balance is very low.";
                await _emailSender.SendEmailAsync(email, message, "you have recieved an email notification");
            }

            //check if location of most recent transaction is different from location of the transaction before it
            //I know it looks sloppy but I figured it would be better if they're both evaluated at the same time
            if (Most_Recent_Transaction.Location != trans_list[trans_list.Count -2].Location)
            {
                message = "This email is to inform you that a transaction has occurred in an abnormal location.";
                await _emailSender.SendEmailAsync(email, message, "you have recieved an email notification");
            }

            
            
            
        }
    }
}

