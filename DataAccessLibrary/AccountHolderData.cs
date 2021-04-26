using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
namespace DataAccessLibrary
{
    public class AccountHolderData : IAccountHolderData
    {
        private readonly ISqlDataAccess db;
        public AccountHolderData(ISqlDataAccess _db)
        {
            db = _db;
        }

        public Task ChangeName(AccountHolderModel accountholder)
        {
            string sql = @"UPDATE account_holder
                            SET First_Name = '" + accountholder.firstName + "', Last_Name='" + accountholder.lastName + "', City='"+accountholder.city +"', State='"+accountholder.state+
                            "' WHERE email='" + accountholder.email + "';";


            return db.SaveData(sql, accountholder);
        }
    }
}
