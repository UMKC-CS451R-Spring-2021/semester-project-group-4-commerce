using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
namespace DataAccessLibrary
{
    public interface IAccountHolderData
    {
        
        public Task ChangeName(AccountHolderModel account);
        Task<List<AccountHolderModel>> getProfileInfo(string user_email);
    }
}
