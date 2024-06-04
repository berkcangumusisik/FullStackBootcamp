

namespace OOPConcept.Example;

internal class ProductRepositoryWithCache : IProductRepository
{
    public bool Any(int productId)
    {
        throw new NotImplementedException();
    }

    public decimal CalculateTax(int tax, int rate, decimal price)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProducts()
    {
        throw new NotImplementedException();
    }

    public int Save(Product product)
    {
        throw new NotImplementedException();
    }
}
