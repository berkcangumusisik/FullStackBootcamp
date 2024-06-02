using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.OOPConcepts.Abstraction
{
    internal interface IStockRepository
    {
        void DecreaseStock(int productId, int count); // Stoktan ürün çıkartma
        bool CheckStock(int productId, int count); // Stok kontrolü
        void GetById();
    }

    internal class StockModule : IStockRepository
    {
        internal int Count { get; set; }
        public void DecreaseStock(int productId, int count)
        {
            // Stoktan ürün çıkartma işlemi
        }

        public bool CheckStock(int productId, int count)
        {
            throw new NotImplementedException();
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }
    }
}
