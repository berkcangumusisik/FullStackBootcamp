 

using System.Collections;
// Arrays
Console.WriteLine("Arrays");
string[] shoppingList  = {"Elma", "Ekmek","Süt","Peynir"};
foreach (var item in shoppingList)
{
    Console.WriteLine(item);
}

Console.WriteLine("--------------------------------");
// ArrayList
Console.WriteLine("ArrayList");
ArrayList students = new ArrayList();
students.Add("Ali");
students.Add("Veli");
students.Add("Ayşe");
foreach (string student in students)
{
    Console.WriteLine(student);  
}

Console.WriteLine("--------------------------------");
// Hashtable
Console.WriteLine("Hashtable");
Hashtable studentGrades = new Hashtable();
studentGrades.Add("Ali", 90);
studentGrades.Add("Veli", 80);
studentGrades.Add("Ayşe", 70);

foreach (DictionaryEntry entry in studentGrades)
{
    Console.WriteLine($"İsim: {entry.Key}, Not: {entry.Value}");
}

Console.WriteLine("--------------------------------");
// Queue
Console.WriteLine("Queue");
Queue orders = new Queue();
orders.Enqueue("Sipariş 1");
orders.Enqueue("Sipariş 2");
orders.Enqueue("Sipariş 3");

while (orders.Count > 0)
{
    Console.WriteLine($"İşleniyor: {orders.Dequeue()}");
}

Console.WriteLine("--------------------------------");
// Stack
Console.WriteLine("Stack");
Stack browserHistory = new Stack();
browserHistory.Push("www.google.com");
browserHistory.Push("www.youtube.com");
browserHistory.Push("www.facebook.com");
while (browserHistory.Count > 0)
{
    Console.WriteLine($"Geri Dönülüyor: {browserHistory.Pop()}");
}

Console.WriteLine("--------------------------------");
// List
Console.WriteLine("List");
List<string> cities = new List<string>();
cities.Add("Ankara");
cities.Add("İstanbul");
cities.Add("İzmir");
foreach (var city in cities)
{
    Console.WriteLine(city);
}

Console.WriteLine("--------------------------------");
// Dictionary
Console.WriteLine("Dictionary");
Dictionary<string, int> cityPopulation = new Dictionary<string, int>();
cityPopulation.Add("Ankara", 6000000);
cityPopulation.Add("İstanbul", 15000000);
cityPopulation.Add("İzmir", 4000000);
foreach (var city in cityPopulation)
{
    Console.WriteLine($"Şehir: {city.Key}, Nüfus: {city.Value}");
}


Console.WriteLine("-------------------------");
// SortedList
Console.WriteLine("SortedList");
SortedList<string, int> cityPopulation2 = new SortedList<string, int>();
cityPopulation2.Add("Ankara", 6000000);
cityPopulation2.Add("İstanbul", 15000000);
cityPopulation2.Add("İzmir", 4000000);
foreach (var city in cityPopulation2)
{
    Console.WriteLine($"Şehir: {city.Key}, Nüfus: {city.Value}");
}

Console.WriteLine("-------------------------");

// Queue<T>
Console.WriteLine("Queue<T>");
Queue<string> orders2 = new Queue<string>();
orders2.Enqueue("Sipariş 1");
orders2.Enqueue("Sipariş 2");
orders2.Enqueue("Sipariş 3");

while (orders2.Count > 0)
{
    Console.WriteLine($"İşleniyor: {orders2.Dequeue()}");
}


Console.WriteLine("-------------------------");
// Stack<T>
Console.WriteLine("Stack<T>");
Stack<string> browserHistory2 = new Stack<string>();
browserHistory2.Push("www.google.com");
browserHistory2.Push("www.youtube.com");
browserHistory2.Push("www.facebook.com");
while (browserHistory2.Count > 0)
{
    Console.WriteLine($"Geri Dönülüyor: {browserHistory2.Pop()}");
}

Console.WriteLine("-------------------------");

// HashSet
Console.WriteLine("HashSet");
HashSet<string> cities2 = new HashSet<string>();
cities2.Add("Ankara");
cities2.Add("İstanbul");
cities2.Add("İzmir");
foreach (var city in cities2)
{
    Console.WriteLine(city);
}

Console.WriteLine("-------------------------");

// LinkedList
Console.WriteLine("LinkedList");
LinkedList<string> cities3 = new LinkedList<string>();
cities3.AddLast("Ankara");
cities3.AddLast("İstanbul");
cities3.AddLast("İzmir");
foreach (var city in cities3)
{
    Console.WriteLine(city);
}


/*
 Tüm array/collection tipleri ile ilgili her biri ayrı bir class'ta olmak üzere örnek gerçekleştirin.

Array Tipleri

Array

System.Collections Namespace

ArrayList
Hashtable
Queue
Stack
System.Collections.Generic Namespace

List<T>
Dictionary<TKey, TValue>
SortedList<TKey, TValue>
Queue<T>
Stack<T>
HashSet<T>
LinkedList<T>

*/