using FullStackBootcamp.App.OOPConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.OOPConcepts.Polymorphism
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void Save()
        {
            Console.WriteLine($"{Id} {Name} {Price}");
        }
    }

    internal class  Phone : Product
    {
        

    }

    internal class  Monitor : Product
    {
        public int Type { get; set; }
        public void Save()
        {
            if(Type == 1) 
            {
                var productJson = JsonSerializer.Serialize(this); // Bu blokta Monitor sınıfının özelliklerini json formatına çeviriyoruz.
                Console.WriteLine(productJson);
            }
            else
            {
                base.Save(); // Eğer Type 1 değilse base sınıfın Save metodunu çağırıyoruz.
            }


        }
    }

    internal class SuperMonitpor : Monitor
    {
        public override void Write()
        {
           base.Save();
        }
    }
}


/**
 * Encapsulation : Bir sınıfın içindeki verilerin ve metotların dışarıdan erişilebilir olup olmamasını kontrol etme işlemidir.
 * Polymorphism : Aynı isimde farklı işlevlere sahip metotların aynı sınıf içerisinde tanımlanabilmesidir. Örneğin Monitor sınıfında Save metodu hem base sınıfın Save metodunu hem de Monitor sınıfının Save metodunu çağırabiliyoruz.
 */