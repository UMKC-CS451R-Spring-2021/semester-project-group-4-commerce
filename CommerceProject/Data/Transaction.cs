using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceProject.Data
{
    public class Transaction
    {
        private String Location;
        private String Processing_Date;
        private int Amount;

        public Transaction(int _Amount, String ProcessingDate, String _Location)
        {
            Amount = _Amount;
            Processing_Date = ProcessingDate;
            Location = _Location;
        }
        public String getLocation() { return Location; }
        public String getDate() { return Processing_Date; }
        public int get_moneyGained() { return Amount; }
    }


}
