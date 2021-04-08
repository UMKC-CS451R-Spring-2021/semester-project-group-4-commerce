using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ITransactionData
    {
        Task<List<TransactionModel>> GetTransactions(string UserName);

        //Task InsertPerson(TransactionModel transaction);

        Task InsertTransaction(TransactionModel transaction);
        
    }
}