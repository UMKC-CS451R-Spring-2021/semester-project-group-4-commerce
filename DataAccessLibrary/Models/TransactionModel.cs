using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
namespace DataAccessLibrary.Models
{
    public class TransactionModelClassMap : ClassMap<TransactionModel>
    {
        public TransactionModelClassMap()
        {
            Map(t => t.Account_Num).Name("Account Number");
            Map(t => t.Trans_Num).Name("Transaction Number");
            Map(t => t.Processing_Date).Name("Processing Date");
            Map(t => t.Type).Name("Transaction Type");
            Map(t => t.Amount).Name("Amount");
            Map(t => t.Description).Name("Description");
            Map(t => t.Balance).Name("Balance");
            Map(t => t.Location).Name("Location");
        }
    }
    public class TransactionModel
    {
        public int Trans_Num { get; set; }

        public int Account_Num { get; set; }

        public String Processing_Date { get; set; }      // potential datatype problem

        public String Type { get; set; }

        public float Amount { get; set; }

        public String Description { get; set; }

        public float Balance { get; set; }

        public String Location { get; set; }

    }
}
