

namespace OOPConcept.Example;

internal interface IProductRepository
{
    int Save(Product product);
    bool Any(int productId);
    List<Product> GetProducts();
    decimal CalculateTax(int tax, int rate, decimal price);
}
