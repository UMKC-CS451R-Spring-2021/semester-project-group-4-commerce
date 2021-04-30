using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface INotificationListData
    {
        Task<List<NotificationListModel>> GetNotifications(string UserName);
        Task<List<NotificationListModel>> GetNotificationsUnread(string UserName);
        Task SetReadToTrue(int Notification_ID);

    }
}