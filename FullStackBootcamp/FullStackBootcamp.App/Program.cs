using FullStackBootcamp.App;
using FullStackBootcamp.App.Nullable;
using FullStackBootcamp.App.OOPConcepts;

Console.WriteLine("Hello, World!");
var loop = new Loop();
loop.ForLoop();

var tax = new Encapsulation.Tax();

var person = new Person();

// Console.WriteLine() => Ekrana yazı yazdırmak için kullanılır.
// Konsol uygulamalarında kod yukarıdan aşağıya doğru çalışır. Tanımlanan kodlar sırasıyla çalışır. Sonrasında konsol uygulaması kapanır. Servera ihtiyaç duymaz.
/*
 Bir kod yazdıktan sonra Compile etmek gerekmektedir. Compile işlemi kodun çalıştırılabilir hale getirilmesi işlemidir. 
 Compile işlemi ile ara bir dil oluşturur ve bu ara dil çalıştırılır.

C# -> .Net Compiler -> Common Intermediate Language (CIL) -> Common Language Runtime (CLR) -> Just In Time Compiler (JIT) -> Platforma özgü makine diline çevirir ve çalıştırır.

Common Intermediate Language (CIL) - > Platforma özgü olmayan bir ara dil olup, .Net Runtime tarafından çalıştırılır.
Common Language Runtime (CLR) -> .Net Runtime, CIL kodunu çalıştıran bir ortamdır.
Just In Time Compiler (JIT) -> CIL kodunu platforma özgü makine diline çevirir ve çalıştırır.

.NET 9 ile artık main metodu olmadan da uygulama çalıştırılabilir.

Classlar ve metotlar birbirine bağlıdır. Classlar içerisinde metotlar bulunur. 
namespace : Bir class'ın bulunduğu klasör yapısını temsil eder. 
namespace Adlandırma
- <company_name>.<product_name>.<compenent.name>
 */


/*
 Variables (Değişkenler) ve Data Types (Veri Tipleri)
- Value Types (Değer Tipleri) : 
    * int , bool, datetime, float, double, decimal, char
    * Memory stack ve heap olarak ikiye ayrılır.
    * Value Types stack'te tutulur.
    * Ufak hacimli verilerdir.
- Reference Types (Referans Tipleri) :
    * string, array, class, interface,record, delegate, event,list
    * Reference Types stack'te referansı tutulur, heap'te ise veri tutulur. Pointer stack'te tutulur.
    * Büyük hacimli verilerdir.
 */