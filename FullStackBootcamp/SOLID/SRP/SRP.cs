using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOLID.SRP;


public class ProductWriter
{
    public void WriteToFile(List<Product> products)
    {
        var textAsJson = JsonSerializer.Serialize(products);
        File.WriteAllText("products.json", textAsJson);
    }

   
    public void WriteToConsole(List<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id} Name: {product.Name}");
        }
    }
}
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

}

public class  ProductService(ProductRepository productRepository)
{


    //private readonly ProductRepository _productRepository;
    //public ProductService(ProductRepository productRepository)
    //{
    //    _productRepository = productRepository;
    //}

    public void Add(Product product)
    {
        product.Price = product.Price * 1.2m; 
        productRepository.Add(product); // Burada interface kullandığımız için Single Responsibility Principle ihlal edilmiyor. Çünkü ProductService classı ProductRepository classına bağımlı değil.

        //productRepository.Add(product); // Bu kısım Single Responsibility Principle ihlal ediyor. ProductService classı ProductRepository classına bağımlı hale gelmiş oluyor. 
    }
    
    public List<Product> GetProducts()
    {
        var products = productRepository.GetProducts();
        foreach (var product in products)
        {
            product.Price = product.Price * 100;
        }
        return products;

    }
}

