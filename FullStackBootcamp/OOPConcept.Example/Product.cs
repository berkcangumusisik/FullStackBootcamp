

namespace OOPConcept.Example;
internal class BaseProduct
{
    public int Id { get; set; }

}
// init anahtar kelimesi sadece constructor içerisinde değer atanabilir. Bir kere değer atanır ve daha sonra değiştirilemez.
internal class Product : BaseProduct
{
    public string Name { get; init; } = default;
    public decimal Price { get; init; }

    private Product()
    {
    }

    // static factory method : Bu metot ile nesne oluşturulurken nesnenin geçerli olup olmadığı kontrol edilir.
    public static Product Create(string Name, decimal Price)
    {
        ArgumentException.ThrowIfNullOrEmpty(Name, nameof(Name));

        CheckPrice(Price);
        return new Product { Name = Name, Price = Price };

    }
    
    private static void CheckPrice(decimal Price)
    {
        if (Price > 3000)
        {
            throw new ArgumentException("Ürün fiyatı 3000'den fazla olamaz.");
        }
    }
}
