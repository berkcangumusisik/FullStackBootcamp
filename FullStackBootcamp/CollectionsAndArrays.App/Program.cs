namespace CollectionsAndArrays.App
{
    internal class Program
    {
        static void method1(object value)
        {
            FileStream f = new FileStream("", FileMode.Create); // FileStream sınıfı System.IO kütüphanesinde bulunur. Burada FileStream sınıfından bir nesne oluşturuldu ve f değişkenine atandı. FileMode.Create ile dosya oluşturuldu.
            f.Dispose(); // f değişkeni ile oluşturulan nesne bellekten silindi.

            // Value tipler memory'den hemen silinir. Referans tipler ise garbage collector tarafından silinir. Dispose metodu ile bellekten silinmesi sağlanabilir. Hacimli veri işlemlerinde bellek yönetimi önemlidir.
            if(value is int i)
            {
                var tax = i * 1.20;
            }
            if(value is string val) // value is string ifadesi ile value değişkeni string mi diye kontrol edilir.  Eğer string ise val değişkenine atanır.
            {
                
            }
        }
        static void Main(string[] args)
        {

            
            // Sayılar dizisi
            var numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;


            //String ile dizi oluşturma
            var names = new string[3];
            names[0] = "John";
            names[1] = "Jack";
            names[2] = "Jill";

            //Object ile dizi oluşturma
            var objects = new object[3];
            objects[0] = "John";
            objects[1] = 10;
            objects[2] = true;

            int i = 10;
            object obj = i; // Boxing
            int j = (int)obj; // Unboxing

            var numbers2 = new[] { 10, 20, 30, 40, 50 }; // Dizi oluşturma ve değer atama aynı satırda yapılabilir.
            var names2 = new[] { "John", "Jack", "Jill" };

            // Diziye eleman eklemek
            var numbers3 = new int[5];
            numbers3[0] = 10; // 0. elemana 10 değeri atandı. Eğer eleman varsa üzerine yazar.

            // Çok boyutlu dizi
            var matrix = new int[2, 3] { { 1,2,3},{4,5,6} }; // 2x3'lük bir matris oluşturuldu.

            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }

            // Çok boyutlu diziye erişim
            var element = matrix[1, 2]; // 1. satır 2. sütundaki eleman alındı.


            // Collections
            //List<T> koleksiyonu : Dizilere benzer ancak boyutu dinamik olarak değiştirilebilir.
            var names4 = new List<string>(); // Boş bir liste oluşturuldu.
            // LinQ to Collections : Listeler üzerinde sorgulama yapılabilir. Arraylerde de vardır ama Listelerde daha zengindir.
            names4.Add("John"); // Listeye eleman eklendi.
            names4.Add("Jack");
            
            // Silme işlemi : Remove metodu ile eleman silinir.
            names4.Remove("John"); // John elemanı silindi.

            // Okunabilirliği yüksek ama performansı düşük olsa bile daha hızlı işlem yapılabilir. Kodu okunabilir ve sürdürülebilir yapılır.
            // Performansın düşük olması, kodun okunabilirliğini ve sürdürülebilirliğini etkilemez.
            // Okunabilirliği düşük kodlar, performansı artırabilir ama sürdürülebilirliği düşürür. 
            // Amaç, kodun okunabilirliğini ve sürdürülebilirliğini artırmak olmalıdır.

            // AddRange metodu ile birden fazla eleman eklenebilir.
            names4.AddRange(new string[] { "John", "Jack", "Jill" });
            foreach (var name in names4)
            {
                Console.WriteLine(name);
            }

            names4.ForEach(x =>
            {

            }); // Foreach döngüsü ile liste elemanlarına erişim sağlanabilir. Daha basit ve okunabilir bir yapıdır.


            
            
        }
    }
}

/*
 Arrays.cs(Diziler)
- Tanımlarken belirli bir boyut belirtmek zorunludur.
- Boyutu belirlendikten sonra değiştirilemez.

Collections(Koleksiyonlar)
- Tanımlarken boyut belirtmek zorunlu değildir.
- Boyutu belirlendikten sonra değiştirilebilir.

Diziler daha verimli çalışırken, koleksiyonlar daha esnek ve kullanışlıdır.
Kaç eleman olacağını bilmiyorsak koleksiyonları tercih etmeliyiz. Aksi halde dizileri tercih etmeliyiz.

Dizi oluşturma :
var diziAdi = new VeriTipi[ElemanSayisi];
var dizi = new int[5]; // 5 elemanlı bir dizi oluşturuldu.
dizi[0] = 10; // 0. elemana 10 değeri atandı.

Obje veri tipi ile dizi oluşturma :
var dizi = new object[3];
dizi[0] = "John";
dizi[1] = 10;
Dizi içerisine farklı veri tipleri eklenebilir.

Boxing : Değer tiplerin obje tipine dönüştürülmesi işlemidir. (int -> object) 
Unboxing : Objelerin değer tiplerine dönüştürülmesi işlemidir. (object -> int)
Mümkün olduğunca boxing ve unboxing işlemlerinden kaçınılmalıdır. Performansı düşürür.
Gelecek data türü belli değilse object kullanılabilir. Performanssız ama gelecek data türü belli değilse kullanılabilir.

 */
