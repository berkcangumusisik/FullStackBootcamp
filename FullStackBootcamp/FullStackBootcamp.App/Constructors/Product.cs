namespace FullStackBootcamp.App.Constructors
{
    // class static olursa içindeki tüm member'lar static olmalıdır. 
    internal class ProductX
    {
        public static int Tax { get; set; } // static member : Direkt sınıf üzerinden erişilebilir.
        public string Name { get; set; } // instance member : Sadece instance üzerinden erişilebilir.
        public int Count { get; set; } // instance member : Sadece instance üzerinden erişilebilir.
        // static member Clean Code prensiplerine aykırıdır. Static member'lar yerine instance member'lar kullanılmalıdır.
       
        //static olmayan Constructor içinden hem static hem de instance member'lara erişilebilir.
        public ProductX()
        {
            Name = "Default Product";
            Count = 0;
        }

        public ProductX(string name, int count)
        {
            Name = name;
            Count = count;
        }

        // static constructor : Erişim belirleyicisi olmaz. Parametre alamaz.Bir sınıfın ilk instance'ı oluşturulduğunda çalışır. Bir kez çalışır bir daha çalışmaz. Sadece static member'ları initialize etmek için kullanılır.
        static ProductX()
        {
            Tax = 18;
        }

        //static  Sadece static member'lar için kullanılır. Instance member'lar için kullanılamaz.
        public static void SetTax(int tax)
        {
            Tax = tax;
        }

        public int TaxCalculation()
        {
            return 100 * Tax;

        }

        public int TaxCalculation2()
        {
            return 200 * Tax;
        }
    }
}

/*
 Constructors( Yapıcı Metotlar)
- Bir sınıfın instance'ı oluşturulduğunda çalışan metotlardır.
- Constructor'lar, sınıfın adı ile aynı isme sahip olmalıdır.
- Constructor'lar geriye değer döndürmezler.
- Eklenmezse default olarak parametresiz bir constructor eklenir.
- Constructorlarda default değerler atanabilir.
- Birden fazla constructor tanımlanabilir. Bu durumda bu durumda overload yapmış oluruz. Bu durumda hangi constructor'ın çağrılacağına karar vermek için parametre sayısı ve tipi dikkate alınır.


Static propertylerden uzak dur. Static propertyler Clean Code prensiplerine aykırıdır. Static propertyler yerine instance propertyler kullanılmalıdır.

 */