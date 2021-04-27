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
            connectionString = "Data Source=NEWBLUE-PC\\COMMERCE_BANK;User ID=Developer2;Password=commerce1;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            string the_query = "SELECT * FROM TRANSACTIONS";//trying to figure out authentication
            Connection.Open();
            return Connection.Query<Transaction>(the_query).ToList<Transaction>();
        }

        public Dictionary<int, decimal> GetMonthlyBalancesPastYear()
        {
            Dictionary<int, decimal> monthly_balances_dict = new Dictionary<int, decimal>();

            string query = "SELECT Avg(Balance), month(Processing_Date) " +
                      "FROM transactions " +
                      "WHERE year(Processing_Date) = 2021 " +
                      "GROUP BY month(Processing_Date) " +
                      "ORDER BY month(Processing_Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            monthly_balances_dict.Add(reader.GetInt32(1), reader.GetDecimal(0));
                        }
                    }
                }
            }

            return monthly_balances_dict;

        }

        public Dictionary<int, decimal> GetDailyBalancesPastMonth(int curr_month)
        {
            Dictionary<int, decimal> daily_balances_dict = new Dictionary<int, decimal>();

            string query = "SELECT Avg(Balance), day(Processing_Date) " +
                      "FROM transactions " +
                      "WHERE year(Processing_Date) = 2021 AND month(Processing_Date) = " + curr_month +
                      " GROUP BY day(Processing_Date) " +
                      "ORDER BY day(Processing_Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            daily_balances_dict.Add(reader.GetInt32(1), reader.GetDecimal(0));
                        }
                    }
                }
            }

            return daily_balances_dict;

        }


    }
}