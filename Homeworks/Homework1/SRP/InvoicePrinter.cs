using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.SRP
{
    public class InvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine($"Fatura ID : {invoice.Id}, Tarih :{invoice.Date} Toplam : {invoice.CalculateTotal()}");
        }
    }
}
