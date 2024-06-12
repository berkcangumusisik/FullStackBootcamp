using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP;

public class ProductRepository
{
    public ProductRepository(string a)
    {
    }
    public List<Product> Products { get; set; } = new();

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public List<Product> GetProducts()
    {
        return Products;
    }
}
public interface IProducHelper
{
}

public interface IProductWriter
{

}

public interface IStockRepository
{
    void Update();
}
public interface IProductRepository : IProducHelper, IProductWriter
{
    void Add(Product product);
    List<Product> GetProducts();
    void Remove(Product product);

    decimal Calculate(int tax, decimal price) // Küçük hesaplamalar burada yapılabilir. 
    {
        return price * tax;
    }
    
}
