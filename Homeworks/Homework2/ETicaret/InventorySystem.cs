using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.ETicaret
{
    public class InventorySystem
    {
        public void OnOrderCompleted(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Stok güncellendi: Sipariş Id: {e.OrderId}");
        }
    }
}
