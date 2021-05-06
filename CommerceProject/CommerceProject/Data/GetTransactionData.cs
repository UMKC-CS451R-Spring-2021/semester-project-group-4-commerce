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

            string query = "SELECT month(a.processing_date), a.balance " +
                            " FROM(SELECT *, ROW_NUMBER() OVER(PARTITION BY DATEPART(month, [processing_date]) ORDER BY[processing_date] DESC) seq" +
                            " FROM transactions) a WHERE seq = 1" +
                            " AND Account_Num = (SELECT Account_Num FROM account" +
                            " INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num WHERE account_holder.Email = '" + UserEmail + "')" +
                            " AND year(processing_date) = '2021';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            monthly_balances_dict.Add(reader.GetInt32(0), reader.GetDecimal(1));
                        }
                    }
                }
            }

            return monthly_balances_dict;

        }

        public Dictionary<int, decimal> GetDailyBalancesPastMonth(int curr_month, string UserEmail)
        {
            Dictionary<int, decimal> daily_balances_dict = new Dictionary<int, decimal>();

            string query = "SELECT day(a.processing_date), a.Balance" +
                            " FROM(SELECT *, ROW_NUMBER() OVER(PARTITION BY DATEPART(day, [processing_date]) ORDER BY[processing_date] DESC) seq" +
                            " FROM transactions) a WHERE seq = 1" +
                            " AND Account_Num = (SELECT Account_Num FROM account" +
                            " INNER JOIN account_holder ON account.ID_Num = account_holder.ID_Num WHERE account_holder.Email = '" + UserEmail + "')" +
                            " AND month(processing_date) = '" + curr_month + "' AND year(processing_date) = '2021';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            daily_balances_dict.Add(reader.GetInt32(0), reader.GetDecimal(1));
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
                            "WHERE YEAR(Date) = 2021 " +
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