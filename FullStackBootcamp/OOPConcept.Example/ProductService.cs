
namespace OOPConcept.Example;

internal  class ProductService(IProductRepository _productRepository)
{
    //private readonly IProductRepository _productRepository;
    //public ProductService(IProductRepository productRepository)
    //{
    //    _productRepository = productRepository;
    //}
    public List<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }
    public int Save(Product product)
    {
        product.Id = _productRepository.GetProducts().Count + 1;
        if (_productRepository.Any(product.Id))
        {
            throw new ArgumentException($"Ürün id ({product.Id}'si db'de bulunuyor. ");
        }
        var newProductId = _productRepository.Save(product);
        return newProductId;
    }

    public decimal CalculateTax(int tax,int rate, decimal price)
    {
        // SqlConnection connection= new SqlConnection("connectionString");
        // connection.Open();
        // SqlCommand command = new SqlCommand("Select * from Tax", connection);
        // SqlDataReader reader = command.ExecuteReader();


        var productHelper = new ProductHelper();
        FileStream file;


        var newTax = tax / rate;


        return price * newTax;


        return 0;


    }
}


// readonly anahtar kelimesi sadece tanımlandığı yerde veya constructor içerisinde değer atanabilir.
/**
try{
    // hata olabilecek kodlar
}catch(Exception ex){
    // hata olduğunda yapılacak işlemler
}finally{
    // hata olsa da olmasa da yapılacak işlemler
}

try-catch ne kadar az kullanılırsa o kadar iyi olur. Çünkü try-catch blokları programın performansını düşürür.

throw new Exception("Hata mesajı"); // Hata fırlatma işlemi
 */