using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App
{
    internal class Loop
    {
        // Döngüler : Tekrar eden işlemleri yapmak için kullanılır.
        // 1. For Döngüsü : Mümkün olduğunca kullanılmamalıdır.
        // for(döngü başlangıç değeri; döngü bitiş koşulu; döngü artış miktarı){}
       
        public void ForLoop()
        {
            // Kod yazarken her zaman ekip arkadaşlarınızı düşünün.
            for (int i = 0; i < 10; i++)
            {
                if(i== 5)
                {
                    Console.WriteLine($"if {i}");
                    // business logic
                    continue; // Döngüyü sonlandırmaz, bir sonraki adıma geçer.

                }

                Console.WriteLine($"for {i}");
            }
        }

        // 2. While Döngüsü : Döngü başlangıcında koşul kontrol edilir.
        public void WhileLoop()
        {
           int i = 10;
           while(i < 10)
            {
                Console.WriteLine($"while {i}");
                i++;
              }
           // break; Döngüyü sonlandırır.
        }

        // 3. Do While Döngüsü : Döngü en az bir kere çalışır. Uygulama çalıştırıldığında koşul kontrol edilmez.
        public void DoWhileLoop()
        {
            int i = 10;
            do
            {
                Console.WriteLine($"do while {i}");
                i++;
            } while (i < 10);
        }

    }
}
