using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.DIP
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
}
