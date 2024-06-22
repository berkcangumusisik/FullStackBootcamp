using Extensions.App;

var number = 5;

Console.WriteLine($"{NumberHelpers.IsEven(number)}");

Console.WriteLine($"{number.IsEven()}");

var name = "Ahmet";
if (name.IsNullOrEmptyOrWhiteSpace())
{
    
}


List<int> numbers = new List<int>() { 1, 30, 2, 6, 7, 10 };
LinkedList<int> numbers2 = new LinkedList<int>();

numbers2.AddLast(10);
numbers2.AddLast(20);
numbers2.AddLast(30);
numbers2.AddLast(5);
foreach (var number5 in numbers2.GetRandomList())
{
    Console.WriteLine(number5);
}

Console.WriteLine("-------------");
foreach (var number6 in numbers.GetRandomList())
{
    Console.WriteLine(number6);
}



// Extension Methodlar : 
// Extension methodlar, var olan bir sınıfın içerisine yeni bir metot eklememizi sağlar.
// Extension methodlar, static bir sınıf içerisinde static bir metot olarak tanımlanır.
// Extension methodlar, this keywordü ile başlar ve bu keywordden sonra hangi sınıfın içerisine metot eklemek istediğimizi belirtiriz.