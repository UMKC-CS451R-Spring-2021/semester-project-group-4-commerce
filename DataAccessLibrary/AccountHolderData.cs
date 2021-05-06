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
                            SET First_Name = '" + accountholder.first_Name + "', Last_Name='" + accountholder.last_Name + "', Phone_Num = '" 
                            + accountholder.phone_num + "', City='" + accountholder.city +"', State='" + accountholder.state +
                            "' WHERE email='" + accountholder.email + "';";


            return db.SaveData(sql, accountholder);
        }

        public Task<List<AccountHolderModel>> getProfileInfo(string user_email)
        {
            string sql = @"SELECT * FROM account_holder " +
                            "WHERE email='" + user_email + "';";


            return db.LoadData<AccountHolderModel, dynamic>(sql, new { });
        }
    }
}
