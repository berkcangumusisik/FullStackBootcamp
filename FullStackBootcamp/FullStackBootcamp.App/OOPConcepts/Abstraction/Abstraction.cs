using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.OOPConcepts.Abstraction
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal interface IWriteProductRepository
    {
        public int CreateProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int productId);
    }

    internal interface IReadProductRepository
    {
        Product GetByIdProduct(int productId);
        List<Product> GetAllProducts();
    }

    internal class ProductRepositoryWithSqlServer : IWriteProductRepository
    {
        public int CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }

    internal class ReadProductRepositoryWithSqlServer : IReadProductRepository
    {
        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetByIdProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
/*
 Interface
- Bir interface, bir sınıfın uygulaması gereken metotları ve özellikleri tanımlar.
- Bir interface, bir sınıfın nasıl davranması gerektiğini belirler.
- interface anahtar kelimesi ile tanımlanır.
- Bir sınıf birden fazla interface'i implement edebilir.
- : işareti ile Class adından sonra interface adı yazılır.
- İsimlendirme genellikle I ile başlar.
- Interface içerisinde metotlar, propertyler, eventler ve indexler bulunabilir.
- Soyut nesnelerdir. Yani içerisinde metotların gövdesi olmaz. Sadece imza bulunur. new anahtar kelimesi kullanılamaz.

Coupling (Bağlantı)  : Bir sınıfın başka bir sınıfa olan bağımlılığıdır. Bağımlılık arttıkça coupling artar. 


 */