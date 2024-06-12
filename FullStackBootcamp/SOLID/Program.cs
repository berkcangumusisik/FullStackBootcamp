using SOLID.DIP;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;
using ProductService = SOLID.DIP.ProductService;

var productService = new ProductService(new ProductRepository("a"));
productService.Add(new Product { Id = 1, Name = "Laptop", Price = 5000 });

var salaryCalculate = new SalaryCalculateService();
//var salary = salaryCalculate.Calculate(5000, SalaryType.Manager);
var salary = salaryCalculate.Calculate(5000, new ManagerSalaryCalculate());
Console.WriteLine(salary);

var isSuccess = false;
BasePhone basePhone;


if (isSuccess)
{
    basePhone = new Iphone();
}
else
{
    basePhone = new Nokia3310();
}


basePhone.Call();

((ITakePhoto)basePhone).TakePhoto();


if (basePhone is ITakePhoto phone)
{
    phone.TakePhoto();
}


if (basePhone as ITakePhoto is not null)
{
}


var productService2 = new ProductService(new ProductRepositoryWithMySql());

var products = productService2.GetProducts();

foreach (var product in products)
{
    Console.WriteLine(product);
}

/*
SOLID Prensipleri
- Solid prensipleri yazılım geliştirme sürecinde yazılımcıların karşılaştığı problemleri çözmek için ortaya çıkmıştır.
- SOLID temel OOP, soyutlama, kalıtım, çok biçimlilik, polimorfizm, kapsülleme gibi kavramları içeren 5 prensipten oluşmaktadır.
1. Single Responsibility Principle (SRP) - Tek Sorumluluk Prensibi
- Bir classın değişmesi için tek bir neden olmalıdır.
- 2 classımız olsun. A ve B olsun. A classı base class ve B classı ise bu base classı miras alan bir class olsun. Eğer B classı A classının bir metotunu override ediyorsa bu durumda B classı A classına bağımlı hale gelir. Bu durumda B classı A classının değişmesi durumunda etkilenecektir. Bu durumda Single Responsibility Principle ihlal edilmiş olur. Yani bir class başka bir classa bağımlı olmamalıdır.

2. Open/Closed Principle (OCP) - Açık/Kapalı Prensibi
- Bir class ya da metotlar genişletilebilir olmalıdır ancak değiştirilemez olmalıdır.
3. Liskov Substitution Principle (LSP) - Liskov'un Yerine Geçme Prensibi
- Bir obje ve onun alt sınıfları birbirinin yerine kullanılabilir olmalıdır. 
4. Interface Segregation Principle (ISP) - Arayüz Ayırma Prensibi
- Birçok müşteriye özeş arayüz, tek bir genel arayüz yerine birden fazla özelleşmiş arayüz sunulmalıdır. Modüllere özgü arayüzler oluşturulmalıdır.
5. Dependency Inversion Principle (DIP) - Bağımlılıkların Ters Çevirilmesi Prensibi
- Yüksek seviyeli modüller düşük seviyeli modüllere bağlı olmamalıdır. Her ikisi de soyutlamalara bağlı olmalıdır. Soyutlamalar ise detaylara bağlı olmamalıdır.
*/