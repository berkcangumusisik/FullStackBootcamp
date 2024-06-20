using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Financial
{
    public class TransactionLogger
    {
        public void OnBalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            Console.WriteLine($"Bakiyeniz değişti. Yeni bakiye: {e.NewBalance}");
        }
    }
}
