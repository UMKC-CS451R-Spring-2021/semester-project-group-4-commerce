using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using Microsoft.Extensions.Configuration;

namespace CommerceProject.Services
{
    public delegate void TriggeredNotificationDelegate(NotificationListModel triggeredNotification);
    public class TriggeredNotificationBroadcastService : IDisposable
    {
        private const string TableName = "notificationList";
        private SqlTableDependency<NotificationListModel> _notifier;
        private IConfiguration _configuration;

        public event TriggeredNotificationDelegate OnTriggeredNotification;

        public TriggeredNotificationBroadcastService(IConfiguration configuration)
        {
            _configuration = configuration;

            // SqlTableDependency will trigger an event 
            // for any record change on monitored table  
            _notifier = new SqlTableDependency<NotificationListModel>(
                 _configuration["ConnectionStrings:DefaultConnection"],
                 TableName);
            _notifier.OnChanged += this.HandleOnChanged;
            _notifier.Start();
        }

        private void HandleOnChanged(object sender, RecordChangedEventArgs<NotificationListModel> e)
        {
            if (e.ChangeType == TableDependency.SqlClient.Base.Enums.ChangeType.Insert)
            {
                OnTriggeredNotification?.Invoke(e.Entity);
            }
        }

        public void Dispose()
        {
            _notifier.Stop();
            _notifier.Dispose();
        }
    }
}

