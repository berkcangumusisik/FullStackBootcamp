using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.OOPConcepts.Abstraction
{
    public class Order 
    {
        
    }
    internal class OrderModule
    {
        private IStockRepository _stockModule;
        public OrderModule(IStockRepository stockModule)
        {
            _stockModule = stockModule;
        }
        public void CreateOrder(Order order)
        {
           var hasStock = _stockModule.CheckStock(1,2);
           if(hasStock== false)
            { 
            
            }

           _stockModule.DecreaseStock(1,2);
        }
    }
}

