using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.SRP
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public double CalculateTotal()
        {
            return Amount * 1.40;
        }
    }
}
