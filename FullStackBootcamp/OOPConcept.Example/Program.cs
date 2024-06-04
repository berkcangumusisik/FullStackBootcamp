namespace OOPConcept.Example;

internal class Program
{
    static void Main(string[] args)
    {
        var product = Product.Create("Laptop", 2000);
        var product2 = Product.Create("Mouse", 50);
        var product3 = Product.Create("Keyboard", 100);
        var productService = new ProductService(new ProductRepository());
        productService.Save(product);
        productService.Save(product2);
        productService.Save(product3);
        foreach (var item in productService.GetProducts())
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}");
        }
    }
}
