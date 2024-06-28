using System;
using Week3.Homework1;

var intScore = new DataStore<int>();
intScore.Add(1);
intScore.Add(2);
intScore.Add(3);
intScore.DisplayAll();

Console.WriteLine("------------------------------------");
int[] intArray = { 3, 2, 1 };
Sorter.Sort(intArray);
foreach (var item in intArray)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------");

string[] stringArray = { "c", "b", "a" };
Sorter.Sort(stringArray);
foreach (var item in stringArray)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------");

List<string> stringNumbers = new List<string> { "1", "2", "3" };
List<int> intNumbers = Convertor.ConvertTo(stringNumbers, int.Parse);
foreach (var item in intNumbers)
{
    Console.WriteLine(item);
}
/*
Ödev: Generic Method ve Class'lar ile İlgili 3 Gerçek Dünya Örneği Açıklama: Bu ödevde, generic method ve generic class kavramlarını gerçek dünya senaryolarında nasıl kullanabileceğinizi göstermeniz istenmektedir.
   
   İstenilenler:
   
   📂 Veri Depolama (Data Storage):
   
   Bir generic sınıf oluşturarak, farklı veri tiplerinde elemanları depolayabilen bir yapı tasarlayın. Örneğin, bir DataStore<T> sınıfı oluşturun ve bu sınıf ile hem int hem string türünde verileri saklayın.
   Örnek kod ve açıklama ile birlikte, bu yaklaşımın esnekliğini ve kod tekrarını nasıl azalttığını açıklayın.
   
   🔢 Algoritmalar (Algorithms):
   
   Generic method kullanarak, farklı veri tiplerinde çalışan bir sıralama algoritması (sorting algorithm) tasarlayın. Örneğin, bir Sort<T> methodu yazın ve bu methodun int[], string[] gibi farklı tiplerdeki dizileri sıralayabilmesini sağlayın.
   Kod örneği ile birlikte, bu metodun tip güvenliği ve kod tekrarını nasıl önlediğini açıklayın.
   
   🔄 Veri Dönüşümü (Data Transformation):
   
   Generic method kullanarak, bir veri tipinden başka bir veri tipine dönüşüm yapan bir yapı tasarlayın. Örneğin, bir ConvertTo<T> methodu ile List<string> türündeki bir veriyi List<int> türüne dönüştürün.
   Kod örneği ile birlikte, bu dönüşümün nasıl yapıldığını ve generic methodların bu süreçteki avantajlarını açıklayın.
 */