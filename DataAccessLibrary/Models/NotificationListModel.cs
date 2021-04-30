using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class NotificationListModel
    {
        public int Notification_ID { get; set; }
        public int Account_Num { get; set; }
        public string Message { get; set; }
        public int Notification_Type { get; set; }
        public DateTime Date { get; set; }
        public bool Read { get; set; }
    }
}
