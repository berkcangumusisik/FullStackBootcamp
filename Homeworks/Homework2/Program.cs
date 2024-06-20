// E Ticaret

using Homework2.ETicaret;
using Homework2.Financial;
using Homework2.Gaming;

var orderProcessor = new OrderProcessor();
var customerService = new CustomerService();
var inventorySystem = new InventorySystem();
var accountingDepartment = new AccountingDepartment();

orderProcessor.OrderCompleted += customerService.OnOrderCompleted;
orderProcessor.OrderCompleted += inventorySystem.OnOrderCompleted;
orderProcessor.OrderCompleted += accountingDepartment.OnOrderCompleted;

orderProcessor.CompleteOrder("1234567890", 299.99);

Console.WriteLine("---------------------------------");

var player = new Character();
var enemy = new Enemy();
var playerActions = new Player();

player.HealthChanged += playerActions.OnHealthChanged;
player.HealthChanged += playerActions.OnHealthChanged;

player.Health = 90;
player.Health = 50;
player.Health = 0;


Console.WriteLine("--------------------------------");

// Finans

var bankAccount = new BankAccount();
var notificationService = new NotificationService();
var transactionLogger = new TransactionLogger();

bankAccount.BalanceChanged += notificationService.OnBalanceChanged;
bankAccount.BalanceChanged += transactionLogger.OnBalanceChanged;

bankAccount.Deposit(100);
bankAccount.Withdraw(50);
bankAccount.Withdraw(70);
bankAccount.Deposit(30);

/*
 Ödev 2:  Delegate ve Event Kullanımı ile ilgili 3 farklı örnek senaryo gerçekleştirin.

Senaryo 1: E-Ticaret Sistemi

Açıklama:
Bir e-ticaret sistemi, müşterilerin alışveriş yapmasına ve sipariş vermesine olanak tanır. Bu sistemde, sipariş tamamlandığında müşteriye ve ilgili departmanlara bilgi vermek için event ve delegate kullanılabilir.

Delegate ve Event Kullanımı:
Bir delegate tanımlanır ve sipariş tamamlandığında tetiklenecek event için kullanılır.
Müşteri hizmetleri departmanı, siparişin tamamlandığını bildiren bir e-posta göndermek için bu event'e abone olur.
Depo yönetim sistemi, stoktan düşülmesi gereken ürünleri güncellemek için aynı event'e abone olur.
Muhasebe departmanı, fatura oluşturmak için bu event'e abone olur.


Senaryo 2: Oyun Geliştirme
Açıklama:
Bir oyun geliştirme projesinde, oyun içerisindeki karakterlerin belirli olaylara tepki vermesi gerekmektedir. Örneğin, bir karakterin canı belirli bir seviyenin altına düştüğünde veya bir düşman öldüğünde bu olaylara tepki vermek için event ve delegate kullanılabilir.


Senaryo 3: Finansal Uygulama
Açıklama:
Bir finansal uygulama, kullanıcıların hesap hareketlerini izlemesine ve belirli finansal olaylardan haberdar olmasına olanak tanır. Örneğin, belirli bir tutarın üzerinde bir işlem gerçekleştirildiğinde veya bir hesapta belirli bir limitin altına düşüldüğünde bu olaylar için event ve delegate kullanılabilir.
 */
