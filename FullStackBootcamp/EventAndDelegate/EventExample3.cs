using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    internal class ProductEvent
    {
        public event EventHandler<decimal> ProductChangedEvent;


        public string Name { get; set; }
        public decimal Price { get; private set; }

        public ProductEvent(string name, decimal price)
        {
            Name = name;
            Price = price;
        }


        public void ChangePrice(decimal price)
        {
            if (price > 500)
            {
                ProductChangedEvent.Invoke(this, price);
            }
            else
            {
                Price = price;
            }
        }
    }
}
