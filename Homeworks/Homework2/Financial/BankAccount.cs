using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Financial
{
    public delegate void BalanceChangedEventHandler(object sender, BalanceChangedEventArgs e);
    public class BalanceChangedEventArgs : EventArgs
    {
        public double NewBalance { get; }
        public BalanceChangedEventArgs(double newBalance)
        {
            NewBalance = newBalance;
        }
    }

    public class BankAccount
    {
        public event BalanceChangedEventHandler BalanceChanged;

        private double _balance;
        public double Balance
        {
            get => _balance;
            set
            {
                _balance = value;
                OnBalanceChanged(_balance);
            }
        }

        protected virtual void OnBalanceChanged(double newBalance)
        {
            BalanceChanged?.Invoke(this, new BalanceChangedEventArgs(newBalance));
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Hesaba {amount} yatırıldı. Yeni bakiye: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Hesaptan {amount} çekildi. Yeni bakiye: {Balance}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }
    }
}
