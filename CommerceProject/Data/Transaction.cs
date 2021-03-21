using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceProject.Data
{
    public class Transaction
    {
        private String location;
        private String date;
        private String money_gained;

        public String getLocation() { return location; }
        public String getDate() { return date; }
        public String get_moneyGained() { return money_gained; }
    }


}
