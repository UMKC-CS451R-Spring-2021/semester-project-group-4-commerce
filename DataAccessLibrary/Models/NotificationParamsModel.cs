using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class NotificationParamsModel
    {
        public int Account_Num { get; set; }
        public bool Timeframe_Is_On { get; set; }
        public TimeSpan Begin_Time { get; set; }
        public TimeSpan End_Time { get; set; }
        public bool Large_Withdrawal_Is_On { get; set; }
        public decimal Withdrawal_Amount { get; set; }
        public bool Low_Balance_Is_On { get; set; }
        public decimal Low_Balance_Threshold { get; set; }
        public bool Send_Email { get; set; }
    }
}
