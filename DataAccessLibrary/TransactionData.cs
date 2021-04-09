using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TransactionData : ITransactionData
    {
        private readonly ISqlDataAccess _db;
        public TransactionData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TransactionModel>> GetTransactions(String UserName)            // change this sql for joins VERY BAD SQL INJECTION VULNERABILITY
        {
            string sql = @"SELECT * FROM transactions
                            WHERE Account_Num = (SELECT Account_Num FROM account
						                            INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num
						                            INNER JOIN login_credentials ON account_holder.ID_Num = login_credentials.ID_Num
						                            WHERE login_credentials.Email = '" + UserName + "');";

            return _db.LoadData<TransactionModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(TransactionModel transaction)
        {
            string sql = @"insert into dbo.account_holder (First_Name, Last_Name, Email)
                            values (@First_Name, @Last_Name, @Email);";                 // use this for inserting data from forms

            return _db.SaveData(sql, transaction);
        }

        public Task InsertTransaction(TransactionModel transaction)
        {
            string sql = @"insert into dbo.TRANSACTIONS (Amount, Description, Location)
                            values (@Amount, @Description, @Location);";
            return _db.SaveData(sql, transaction);
        }
    }
}
