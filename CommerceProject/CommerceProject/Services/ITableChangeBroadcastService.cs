using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using CommerceProject.Models;

namespace CommerceProject.Services
{
    public delegate void BalanceChangeDelegate(object sender, BalanceChangeEventArgs args);

    public class BalanceChangeEventArgs : EventArgs
    {
        public AccountModel NewValue { get; }
        public AccountModel OldValue { get; }

        public BalanceChangeEventArgs(AccountModel newValue, AccountModel oldValue)
        {
            this.NewValue = newValue;
            this.OldValue = oldValue;
        }
    }

    public interface ITableChangeBroadcastService : IDisposable
    {
        public event BalanceChangeDelegate OnBalanceChanged;
        IList<AccountModel> GetCurrentValues();
    }

}
