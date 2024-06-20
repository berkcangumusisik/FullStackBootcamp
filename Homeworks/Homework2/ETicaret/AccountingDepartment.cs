﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.ETicaret
{
    public class AccountingDepartment
    {
        public void OnOrderCompleted(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Muhasebe departmanı tarafından fatura kesildi. Sipariş No: {e.OrderId}, Tutar: {e.OrderAmount}");
        }
    }
}
