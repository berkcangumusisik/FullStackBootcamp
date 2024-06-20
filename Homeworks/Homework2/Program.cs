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
