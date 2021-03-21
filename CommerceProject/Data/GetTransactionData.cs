using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace CommerceProject.Data
{
    public class GetTransactionData
    {
        private String connectionString;
        
        public GetTransactionData()
        {
            connectionString = "";

        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public Transaction GetTransactions(int account_id)
        {
            string the_query = @"SELECT Amount, Location, Processing_Date FROM TRANSACTIONS";//trying to figure out authentication
            Connection.Open();
            return Connection.Query(the_query).FirstOrDefault();
        }

        
    }
}
 