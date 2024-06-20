using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.DIP
{
    public class CreditCardProcessor: IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Kredi kartı ödemesi işleniyor: {amount}");
        }
    }
}
