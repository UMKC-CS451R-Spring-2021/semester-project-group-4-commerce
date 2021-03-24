using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ITransactionData
    {
        Task<List<TransactionModel>> GetTransactions();
        Task InsertPerson(TransactionModel transaction);
    }
}