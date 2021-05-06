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
						                            WHERE account_holder.Email = '" + UserName + "')" +
                                                    "ORDER BY Date DESC;";

            return _db.LoadData<NotificationListModel, dynamic>(sql, new { });
        }
        public Task<List<NotificationListModel>> GetNotificationsUnread(String UserName)
        {
            string sql = @"SELECT * FROM notificationList
                            WHERE Account_Num = (SELECT Account_Num FROM account
						                            INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num
						                            WHERE account_holder.Email = '" + UserName + "')" +
                                "AND [Read] = 0 ORDER BY Date DESC;";

            return _db.LoadData<NotificationListModel, dynamic>(sql, new { });
        }

        public Task<List<NotificationListModel>> GetNotificationsByDates(String UserName, string StartDate, string StopDate)
        {
            string sql = @"SELECT * FROM notificationList
                            WHERE Account_Num = (SELECT Account_Num FROM account
						                            INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num
						                            WHERE account_holder.Email = '" + UserName + "') " +
                                "AND Date >= '" + StartDate + "' AND Date <= '" + StopDate + " 23:59:59.999' ORDER BY Date DESC;";

            return _db.LoadData<NotificationListModel, dynamic>(sql, new { });
        }

        public Task<List<NotificationParamsModel>> GetNotificationSettings(String UserName)
        {
            string sql = @"SELECT * FROM notificationParameters
                            WHERE Account_Num = (SELECT Account_Num FROM account
						                            INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num
						                            WHERE account_holder.Email = '" + UserName + "');";

            return _db.LoadData<NotificationParamsModel, dynamic>(sql, new { });
        }

        public Task SetReadToTrue(int Notification_ID)
        {
            string sql = @"UPDATE notificationList
                            SET [Read] = 'true'
                            WHERE Notification_ID = " + Notification_ID + ";";

            return _db.ExecuteSql(sql);
        }

        public Task SetParameters(string UserName, bool timeIsOn, string beginTimeframe, string endTimeFrame,
                                    bool WithdrawalIsOn, decimal withdrawalThresh, bool LowBalanceIsOn,
                                    decimal balanceThresh, bool EmailNoteIsOn)
        {
            string sql = @"	UPDATE notificationParameters
	                            SET 
	                            	Timeframe_Is_On = '" + timeIsOn + "'," + 
	                            	" Begin_Time = cast('" + beginTimeframe + "' AS time)," +
	                            	" End_Time = cast ('" + endTimeFrame + "' AS time)," +
	                            	" Large_Withdrawal_Is_On = '" + WithdrawalIsOn + "'," +
	                            	" Withdrawal_Amount = " + withdrawalThresh + "," +
	                            	" Low_Balance_Is_On = '" + LowBalanceIsOn + "'," +
	                            	" Low_Balance_Threshold = " + balanceThresh + "," +
	                            	" Send_Email = '" + EmailNoteIsOn + "'" +
	                            " WHERE Account_Num = (SELECT Account_Num FROM account" +
	                            					" INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num" +
	                            					" WHERE account_holder.Email = '" + UserName + "');";

            return _db.ExecuteSql(sql);
        }

    }
}