using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class NotificationListData : INotificationListData
    {
        private readonly ISqlDataAccess _db;
        public NotificationListData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<NotificationListModel>> GetNotifications(String UserName)
        {
            string sql = @"SELECT * FROM notificationList
                            WHERE Account_Num = (SELECT Account_Num FROM account
						                            INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num
						                            WHERE account_holder.Email = '" + UserName + "');";

            return _db.LoadData<NotificationListModel, dynamic>(sql, new { });
        }

        public Task<List<NotificationListModel>> GetNotificationsUnread(String UserName)
        {
            string sql = @"SELECT * FROM notificationList
                            WHERE Account_Num = (SELECT Account_Num FROM account
						                            INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num
						                            WHERE account_holder.Email = '" + UserName + "')" +
                            "AND [Read] = 0;";

            return _db.LoadData<NotificationListModel, dynamic>(sql, new { });
        }

        public Task SetReadToTrue(int Notification_ID)
        {
            string sql = @"UPDATE notificationList
                            SET [Read] = 'true'
                            WHERE Notification_ID = " + Notification_ID + ";";

            return _db.ExecuteSql(sql);
        }
    }
}
