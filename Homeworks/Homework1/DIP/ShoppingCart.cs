using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.DIP
{
    public class ShoppingCart
    {
        private IPaymentProcessor _paymentProcessor;

        public ShoppingCart(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(double amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
