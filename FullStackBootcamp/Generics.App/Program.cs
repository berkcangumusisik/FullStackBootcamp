/*
Generics 
- Genericler, bir sınıfın veya metotun hangi veri türleriyle çalışacağını belirlemek için kullanılır.
- Genericler, tip güvenliği sağlar.
- List<T> sınıfı, generic bir sınıftır.
- ArrayList sınıfı, generic olmayan bir sınıftır. Yani ArrayList sınıfı, her türden veri türünü depolayabilir. Object türünden nesneleri depolar.
- Eğer tip güvenliği sağlamak istiyorsak, generic sınıfları kullanmalıyız.
- Generic sınıflar, performans açısından daha iyidir.
- Generic bazı yapılar: List<T>, Dictionary<TKey, TValue>, Queue<T>, Stack<T>, LinkedList<T>, HashSet<T>, 

- Genericler tip güvenliği, performans ve kod tekrarını önlemek için kullanılır.
 */

using System.Collections;
using Generics.App;

List <int> numbers = new List<int>();
Dictionary<int, int> dictionary = new Dictionary<int, int>();
IEnumerable<int> numbers2 = new List<int>();

//ArrayList numbers2 = new ArrayList();
//numbers2.Add(10);
//numbers2.Add("Ankara");


var methodExample = new MethodExample();
Console.WriteLine(methodExample.Add(5, 10));
Console.WriteLine(methodExample.AddGeneric(5.5, 10.4));
Console.WriteLine(methodExample.AddGeneric(5, 10));
Console.WriteLine(methodExample.CompareGeneric(7, 5));
Console.WriteLine(methodExample.AddGeneric(5, 5));
Console.WriteLine(methodExample.AddGeneric("ahmet", "mehmet"));
Console.WriteLine(methodExample.AddGeneric(10.2, 10.5));

var cache = new Cache();
cache.AddCache("userId",23);
cache.AddCache("productID",10);
cache.AddCache("mail","ahmet@outlook.com");

Console.WriteLine(cache.GetCache("userId"));

var cacheGeneric = new CacheGeneric<string, int>();
cacheGeneric.AddCache("userId", 23);
cacheGeneric.AddCache("productID", 10);
Console.WriteLine(cacheGeneric.GetCache("userId"));

var cacheGeneric2 = new CacheGeneric<string, string>();
cacheGeneric2.AddCache("email", "ahmet@gmail.com");
Console.WriteLine(cacheGeneric2.GetCache("email"));

List<int> numbers3 = [5, 7, 10, 2, 30];
List<string> cities = ["Ankara", "İstanbul", "İzmir", "Adana"];

var sortingExample = new SortingExample<int>();
var sortedNumbers = sortingExample.Sort(numbers3);
foreach (var number in sortedNumbers)
{
    Console.WriteLine(number);
}


var sorting2 = new SortingExample2<List<int>,int>();
var sortedNumbers2 = sorting2.Sort(numbers3);
foreach (var number in sortedNumbers2)
{
    Console.WriteLine(number);
}


var sorting3 = new SortingExample2<LinkedList<int>,int>();
LinkedList<int> numbers4 = new LinkedList<int>();
numbers4.AddLast(5);
numbers4.AddLast(10);
numbers4.AddLast(2);
numbers4.AddLast(30);
sorting3.Sort(numbers4).ForEach(x=>{ Console.WriteLine(x); });