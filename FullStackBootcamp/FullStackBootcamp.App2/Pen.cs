using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App2;

internal class Pen
{

    // Field (Alan) : Class içerisinde tanımlanan değişkenlere field denir.
    private int _height;
    public int Height { 
        get => _height;
       //get { return _height; }
      //set => _height = value;
        set
        {
            if (value > 500) throw new Exception("500'den büyük olamaz");
            _height = value;
        }

        //set
        //{ if (value > 500) throw new Exception("500'den büyük olamaz");
        //    _height = value; 
        //} 
    }
    public int Width { get; set; }
    public string Color { get; set; }

    public const int tax = 20; // const : Değişkenin değeri değiştirilemez. 
    // Değişken tanımlama : [Access Modifier] [Data Type] [Variable Name] = [Value];

    public void Write(int a, int b)
    {
        // var : Değişkenin veri tipini belirtmek zorunda kalmadan tanımlama yapmamızı sağlar.
        var c = a * b;
        var d = 2 + 5;
        dynamic e = a + b; // dynamic : Değişkenin veri tipini çalışma zamanında belirlememizi sağlar. Performansı düşürür. 
    
        c = c * 200;
        Console.WriteLine(c);
    }
    // [Access Modifier] [Return Type] [Method Name] ([Parameters])
    // Bir metodu diğer metotlardan ayıran 2 özelliği vardır. 
    // 1. Parametrelerin veri türü
    public string Write(string a, int b) => a + b;
    //{
    //    return a + b;
    //}
    //2. Parametrelerin sayısı 
    public void Write(int a, int b, int c)
    {

    }
    // Dönüş tipi bir metodun diğer metotlardan ayıran bir özellik değildir.
    // void : Geriye bir değer döndürmeyen metotlarda kullanılır. return kullanılması gerekir. 
}


/*
 Yazılımda Kohezyon : Birbirleriyle ilişkili olan işlemlerin bir arada olmasıdır. Bu sayede kodun okunabilirliği artar. Yüksek kohezyon düşük coupling ile birlikte kullanılır.
 Coupling : Birbirleriyle ilişkili olmayan işlemlerin bir arada olmamasıdır. Modüller arasındaki ilişkiyi ifade eder. Bir modülün diğer modüle bağımlılığını ifade eder.
 Yüksek kohezyon ve düşük coupling bir arada kullanılır.
 */

/*
 property : Field'ın dışarıdan erişilebilir olmasını sağlar ve field'ın değerini değiştirmek için kullanılır.
 get : Field değerini döndürür.
 set : Field değerini değiştirir.

 Erişim Belirleyicileri (Access Modifiers) :
 - public : Her yerden erişilebilir.
 - private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
   
 */

/*
 Design Time : Kod yazım aşaması
 Compile Time : Kodun derlendiği aşama
 Run Time : Kodun çalıştırıldığı aşama
 */

/*
 float => 1.1 gibi ondalıklı sayıları tutar.
 double => 1.23 gibi ondalıklı sayıları tutar.
 decimal => 1.233443432423 gibi ondalıklı sayıları tutar. Para birimi gibi hassas hesaplamalarda kullanılır.

 */