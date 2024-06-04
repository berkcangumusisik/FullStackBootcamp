namespace OOPConcept.Example;

internal class ProductRepository: IProductRepository
{
    private List<Product> Products { get; set; } = new();

    public bool Any(int productId)
    {
        return Products.Any(p => p.Id == productId);
    }

    public decimal CalculateTax(int tax, int rate, decimal price)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProducts()
    {
        var innerProductList = new List<Product>();

        foreach (var product in Products)
        {
            innerProductList.Add(product);
        }
        return innerProductList;
    }
    public int Save(Product product)
    {
        
        Products.Add(product);
        return product.Id;
    }
}


// ArgumentNullExeption.ThrowIfNull bu metot null gelirse exception fırlatır.
// ArgumentNullException.ThrowIfNullOrEmpty bu metot null veya boş gelirse exception fırlatır.
// isNulllOrEmpty metodu string ifade null veya boş ise true döner.
