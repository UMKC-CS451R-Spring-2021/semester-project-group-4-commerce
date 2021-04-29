using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class TransactionModel
    {
        public int Trans_Num { get; set; }

        public int Account_Num { get; set; }

        public String Processing_Date { get; set; }      // potential datatype problem

        public String Type { get; set; }

        public decimal Amount { get; set; }

        public String Description { get; set; }

        public decimal Balance { get; set; }

        public String Location { get; set; }

    }
}
