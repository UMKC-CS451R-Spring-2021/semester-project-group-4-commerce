using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using CommerceProject.Models;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

namespace CommerceProject.Services
{
    public class TableChangeBroadcastService : ITableChangeBroadcastService, IDisposable
    {
        private const string TableName = "account";
        private SqlTableDependency<AccountModel> _notifier;
        private IConfiguration _configuration;

        public event BalanceChangeDelegate OnBalanceChanged;

        public TableChangeBroadcastService(IConfiguration configuration)
        {
            _configuration = configuration;

            // SqlTableDependency will trigger an event 
            // for any record change on monitored table  
            _notifier = new SqlTableDependency<AccountModel>(
                 _configuration["ConnectionStrings:DefaultConnection"],
                 TableName);
            _notifier.OnChanged += this.TableDependency_Changed;
            _notifier.Start();
        }

        // This method will notify the Blazor component about the transaction change
        private void TableDependency_Changed(object sender, RecordChangedEventArgs<AccountModel> e)
        {
            if (this.OnBalanceChanged != null) // "If OnBalancedChaged has been initialized in Homepage"
            {
                this.OnBalanceChanged(this, new BalanceChangeEventArgs(e.Entity, e.EntityOldValues));

            }
        }


        // This method is used to populate the HTML view 
        // when it is rendered for the first time
        public IList<AccountModel> GetCurrentValues()
        {
            var result = new List<AccountModel>();

            using (var sqlConnection = new SqlConnection(_configuration["ConnectionString"]))
            {
                sqlConnection.Open();

                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "SELECT Balance FROM " + TableName;
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                result.Add(new AccountModel
                                {
                                    Balance = reader.GetFloat(reader.GetOrdinal("Balance"))
                                });
                            }
                        }
                    }
                }
            }

            return result;
        }

        public void Dispose()
        {
            _notifier.Stop();
            _notifier.Dispose();
        }

    }
}