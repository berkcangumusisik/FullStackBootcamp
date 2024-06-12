using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays.App
{
    internal record Person(string Name, string Surname); // Bu kod satırı ile Person adında bir sınıf oluşturuldu. Bu sınıfın Name ve Surname adında iki özelliği var. Bu özelliklerin değerleri sadece okunabilir. Yani sadece get metodu bulunur. Bu sınıfın nesneleri immutable'dır. Yani değerleri değiştirilemez. Bu sınıfın nesnelerine değer ataması yapılırken değerlerin sırasına dikkat edilmelidir. Değerlerin sırası değiştirilemez. Değerlerin sırası değiştirilirse hata alınır.

    internal record person2
    {
        
        public string Name { get; init; } // Name özelliğine değer ataması yapılırken sadece init metodu kullanılabilir. Bu özellik sadece okunabilir.
        public string Surname { get; init; } // Surname özelliğine değer ataması yapılırken sadece init metodu kullanılabilir. Bu özellik sadece okunabilir.

        public person2()
        {
            var p1 = new Person("John", "Doe");
            var p2 = new Person("Jack", "Doe");
            if (p1 == p2)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }
        }
    }
   
}
