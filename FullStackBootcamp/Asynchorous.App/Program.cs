
using Asynchorous.App;

var sync = new SyncExample();
Console.WriteLine("1.adım");
await sync.RunAsync();
Console.WriteLine("2.adım");

var key = Console.ReadKey();

var multiThread = new MultiThreadExample();

Console.WriteLine("step 1");
multiThread.TaskExample("https://www.google.com");
Console.WriteLine("step 2");

Console.ReadKey();
/*
 * Senkron Programlama : Programın işlemlerinin sırasıyla yapılmasıdır.
 *
 *
 * Senkron, Asenkron ve Multithreading tek işlemci üzerinde çalışan programlar için geçerlidir.
 * Paralel programlama ise çok işlemci üzerinde çalışan programlar için geçerlidir.
 */