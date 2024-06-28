using Week3.Homework2;

ICollection<int> numbers = new List<int> { 1, 2, 3 };
numbers.AddRange(new[] {4,5,6});
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------------------------------");

IEnumerable<int> filtered = numbers.WhereGreaterThan(3);
foreach (var number in filtered)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------------------------------");

List<int> list = new List<int> { 1, 2, 3 };
list.ReverseOrder();
foreach (var number in list)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------------------------------");

var dictionary = new Dictionary<string, int>
{
    {"A", 1},
    {"B", 2},
    {"C", 3}
};

int value = dictionary.GetOrDefault("B");
Console.WriteLine(value);


/**
 Ödev: Extension Methodlar ile İlgili Örnekler
Açıklama: Bu ödevde, verilen sınıflar için çeşitli extension methodlar yazmanız istenmektedir. Extension methodlar, mevcut sınıflara yeni yetenekler eklemek için kullanılır ve mevcut kodu değiştirmeden yeni işlevsellikler sağlar.

İstenilenler:

 ICollection için Extension Method:

ICollection türündeki bir koleksiyona, eleman ekleme veya çıkarma işlemlerini daha kolay hale getiren bir extension method yazın. Örneğin, AddRange<T> adlı bir method ile birden fazla elemanı tek seferde ekleyin.

 IEnumerable için Extension Method:

IEnumerable türündeki bir koleksiyondan, belirli bir koşula göre filtreleme yapabilen bir extension method yazın. Örneğin, WhereGreaterThan adlı bir method ile belirli bir değerden büyük olan elemanları filtreleyin.

 List için Extension Method:

List türündeki bir koleksiyona, elemanları tersine çeviren veya belirli bir sıraya göre sıralayan bir extension method yazın. Örneğin, ReverseOrder adlı bir method ile listeyi ters sıraya çevirin.

 Dictionary için Extension Method:

Dictionary türündeki bir koleksiyona, belirli bir anahtar-değer çiftini arama veya çıkartma işlemlerini kolaylaştıran bir extension method yazın. Örneğin, GetOrDefault adlı bir method ile belirtilen anahtarın değerini bulun, yoksa varsayılan bir değer döndürün.

 */