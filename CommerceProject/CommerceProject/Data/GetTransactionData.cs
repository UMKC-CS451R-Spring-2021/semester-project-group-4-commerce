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

        public Dictionary<int, decimal> GetMonthlyBalancesPastYear(string UserEmail)
        {
            Dictionary<int, decimal> monthly_balances_dict = new Dictionary<int, decimal>();

            string query = "SELECT Avg(Balance), month(Processing_Date) " +
                      "FROM transactions " +
                      "WHERE year(Processing_Date) = 2021 " +
                      "AND Account_Num = (SELECT Account_Num FROM account INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num WHERE account_holder.Email = '" + UserEmail + "')" +
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

        public Dictionary<int, decimal> GetDailyBalancesPastMonth(int curr_month, string UserEmail)
        {
            Dictionary<int, decimal> daily_balances_dict = new Dictionary<int, decimal>();

            string query = "SELECT Avg(Balance), day(Processing_Date) " +
                      "FROM transactions " +
                      "WHERE year(Processing_Date) = 2021 AND month(Processing_Date) = " + curr_month +
                      "AND Account_Num = (SELECT Account_Num FROM account INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num WHERE account_holder.Email = '" + UserEmail + "')" +
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

        public Dictionary<int, int> GetMonthlyNotifications(string UserEmail)
        {
            Dictionary<int, int> monthly_notifications = new Dictionary<int, int>();

            string query = "SELECT Notification_Type, SUM(Notification_Type) FROM notificationList " +
                            "WHERE Date >= DATEADD(month, -1, GETDATE()) " +
                            "AND Account_Num = (SELECT Account_Num FROM account " +
                            "INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num WHERE account_holder.Email = '" + UserEmail + "') " +
                            "GROUP BY Notification_Type " +
                            "ORDER BY Notification_Type";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            monthly_notifications.Add(reader.GetInt32(0), reader.GetInt32(1));
                        }
                    }
                }
            }
            return monthly_notifications;
        }

        public Dictionary<int, int> GetYearlyNotifications(string UserEmail)
        {
            Dictionary<int, int> yearly_notifications = new Dictionary<int, int>();

            string query = "SELECT Notification_Type, SUM(Notification_Type) FROM notificationList " +
                            "WHERE Date >= DATEADD(year, -1, GETDATE()) " +
                            "AND Account_Num = (SELECT Account_Num FROM account " +
                            "INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num WHERE account_holder.Email = '" + UserEmail + "') " +
                            "GROUP BY Notification_Type " +
                            "ORDER BY Notification_Type";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yearly_notifications.Add(reader.GetInt32(0), reader.GetInt32(1));
                        }
                    }
                }
            }
            return yearly_notifications;
        }


    }
}