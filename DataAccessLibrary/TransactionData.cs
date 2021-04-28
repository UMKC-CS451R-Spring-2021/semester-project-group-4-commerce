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
						                            WHERE account_holder.Email = '" + UserName + "');";  // currently uses no form input

            return _db.LoadData<TransactionModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(TransactionModel transaction)
        {
            string sql = "";                 // use this for inserting Person data from forms

            return _db.SaveData(sql, transaction);
        }

        public Task InsertTransaction(TransactionModel transaction)
        {
            // use this for inserting new transaction
            string sql = @"insert into dbo.TRANSACTIONS (Account_Num, Processing_Date, Type, Amount, Description, Balance, Location)
                            values (@Account_Num, @Processing_Date, @Type, @Amount, @Description, @Balance, @Location);";                
            

            return _db.SaveData(sql, transaction);
        }

        public Task<List<TransactionModel>> GetAccountNum(String UserName)
        {
            string sql = @"SELECT * FROM dbo.account
                            WHERE ID_Num = (SELECT ID_Num FROM account_holder
                                                WHERE Email = '" + UserName + "');";

            return _db.LoadData<TransactionModel, dynamic>(sql, new { });
        }
    }
}
