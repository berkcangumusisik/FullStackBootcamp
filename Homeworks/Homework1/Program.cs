// Single Responsibility Principle

using Homework1.DIP;
using Homework1.ISP;
using Homework1.LSP;
using Homework1.OCP;
using Homework1.SRP;

var invoice = new Invoice{Id = 1, Date = DateTime.Now, Amount = 10000};
var invoicePrinter = new InvoicePrinter();
var invoiceRepository = new InvoiceRepository();

invoicePrinter.Print(invoice);
invoiceRepository.Save(invoice);


Console.WriteLine("-----------------------------------");

// Open/Closed Principle
var shapes = new List<Shape>
{
    new Circle{Radius = 5},
    new Rectangle{Width = 5, Height = 10}
};

var areaCalculator = new AreaCalculator();
Console.WriteLine(areaCalculator.CalculateArea(shapes));

Console.WriteLine("-----------------------------------");
// LSP
var transportationManager = new TransportationManager();
var car = new Car();
var bicycle = new Bicycle();

transportationManager.StartTransportation(car);
transportationManager.StartTransportation(bicycle);

Console.WriteLine("-----------------------------------");

// Interface Segregation Principle
IWorker humanWorker = new HumanWorker();
IWorker robotWorker = new RobotWorker();
ISleeper humanSleeper = new HumanWorker();

humanWorker.Work();
robotWorker.Work();
humanSleeper.Sleep();

Console.WriteLine("-----------------------------------");
// Dependency Inversion Principle
IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
IPaymentProcessor payPalProcessor = new PayPalProcessor();

var shoppingCart = new ShoppingCart(creditCardProcessor);
shoppingCart.Checkout(200);

shoppingCart = new ShoppingCart(payPalProcessor);
shoppingCart.Checkout(300);

/*
Ödev 1:  SOLID prensiplerinin her birini uygulamak için her prensibi ayrı bir sınıf içinde gerçekleştiriniz.

SOLID prensipleri, yazılım geliştirme sürecinde daha esnek, genişletilebilir ve bakım yapılabilir kodlar yazmak için beş temel prensibi içerir. Bu prensipler:

S - Single Responsibility Principle (Tek Sorumluluk Prensibi)
O - Open/Closed Principle (Açık/Kapalı Prensibi)
L - Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)
I - Interface Segregation Principle (Arayüz Ayrımı Prensibi)
D - Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi)
 */