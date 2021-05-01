using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface INotificationListData
    {
        Task<List<NotificationListModel>> GetNotifications(string UserName);
        Task<List<NotificationListModel>> GetNotificationsUnread(string UserName);
        Task<List<NotificationListModel>> GetNotificationsByDates(String UserName, string StartDate, string StopDate);

        Task SetReadToTrue(int Notification_ID);
        Task SetParameters(string UserName, bool timeIsOn, string beginTimeframe, string endTimeFrame,
                                    bool WithdrawalIsOn, decimal withdrawalThresh, bool LowBalanceIsOn,
                                    decimal balanceThresh, bool EmailNoteIsOn);
    }
}