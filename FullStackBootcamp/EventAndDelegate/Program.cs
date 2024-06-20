using EventAndDelegate;

var categoryRepository = new CategoryRepository();

categoryRepository.SetThresholdCategoryCount(3);

categoryRepository.ThresholdCategoryCountEvent += CategoryRepository_ThresholdCategoryCountEvent;


categoryRepository.ThresholdCategoryCountEvent += CategoryRepository_ThresholdCategoryCountEvent1;


void CategoryRepository_ThresholdCategoryCountEvent(object? sender, int categoryCount)
{
    if (categoryCount >= 4)
    {
        throw new Exception("hata var sayı 4 oldu");
    }

    Console.WriteLine($"kategori sayısı eşik değerini({categoryCount}) aştı(1)");
}


void CategoryRepository_ThresholdCategoryCountEvent1(object? sender, int categoryCount)
{
    Console.WriteLine($"kategori sayısı eşik değerini({categoryCount}) aştı(2)");
}


var category = new Category() { Id = 20, Name = "kalem 20" };
categoryRepository.Add(category);
categoryRepository.Add(category);
categoryRepository.Add(category);
categoryRepository.Add(category);
categoryRepository.Add(category);

var productEvent = new ProductEvent("kalem 1", 100);

productEvent.ProductChangedEvent += ProductEventProductChangedEvent;

void ProductEventProductChangedEvent(object? sender, decimal price)
{
    Console.WriteLine($"Product Changed. current Value:  {price}");
}

productEvent.ChangePrice(600);


var person = new Person();
person.FirstName = "Berkcan";
person.LastName = "Gümüşışık";
person.ProfilePictureUrl = "https://url.com";
person.ProfilePictureChanged += (pictureUrl) => { Console.WriteLine($"url değiştir :{pictureUrl}"); };var product = new Product();
product.StockCountEvent += Product_StockCountEvent;
void Product_StockCountEvent(int stock)
{
    Console.WriteLine("Stock is not enough.");
}
for(int i = 0; i < 30; i++)
{
    product.Stock = i;
    Console.WriteLine(product.Stock);

    //if(product.StockCount <= product.Stock)
    //{
    //    Console.WriteLine("Stok yeterli");
    //}
    //else
    //{
    //    Console.WriteLine("Stok yetersiz.");
    //}
}



SuperSalaryCalculator superSalaryCalculator = new SuperSalaryCalculator();
var salary = superSalaryCalculator.GoodCalculate(10, 2, SalaryCalculator.ManagerCalculate);
Console.WriteLine(salary);



FunctionDelegateExample functionDelegateExample = new FunctionDelegateExample();

var delegateExample2 = new DelegateExample2();
Console.WriteLine(delegateExample2.Calculate(2, 5, CalculatorType.Add));
Console.WriteLine(delegateExample2.GoodCalculate(2,5, (a, b) =>
{
    var result = a + b;
    return result;
}));
#region Example2

Operator operator5 = delegate (int a, int b)
{
    return a + b;
};

Operator operator6 = (a, b) =>
{
    return a + b;
};

Operator operator7 = (a, b) => a + b;

Operator3 operator10 = Add2;
operator10(10);


#endregion

#region Example 1
Operator myOperator = Add; // Delegate tanımlama
myOperator += Multiply; // Delegate'e bir başka metodu ekler.
Operator2 myOperator2 = Add2;
myOperator2 -= Subtraction2;
var sum = myOperator.Invoke(10, 20); // Invoke metodu ile delegate çağrılır.
var sum2 = myOperator(10, 20); // Bu şekilde de delegate çağrılabilir.
Console.WriteLine(sum);
Console.WriteLine(sum2);
# endregion


int Add(int a, int b)
{
    return a + b;
}

int Multiply(int a, int b)
{
    return a * b;
}

void Add2(int a, int b = 20)
{
    Console.WriteLine($"Toplam :{a + b}");
}

void Multiply2(int a, int b)
{
    Console.WriteLine($"Çarpım :{a * b}");
}

void Subtraction2(int a, int b)
{
    Console.WriteLine($"Çıkarma :{a - b}");
}

int Subtraction3(int a, int b, int c)
{
    Console.WriteLine($"Çıkarma :{a - b}");
    return 1;
}


internal delegate int Operator(int a, int b); // Delegate tanımlama
internal delegate void Operator2(int a, int b);
internal delegate void Operator3(int a, int b = 50);
