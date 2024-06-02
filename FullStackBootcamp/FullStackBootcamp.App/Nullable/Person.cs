using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.Nullable;


    internal class Person
{
    public int? Age { get; set; }

    public string? Name { get; set; }

    public string Surname { get; set; } = default!;
}

public class PersonService
{
    void Method1()
    {
        var person = new Person() { Age = 25, Name = null, Surname = "Gümüşışık" };

        if (person.Age.HasValue)
        {
            int age = person.Age.Value;
        }
    }
}

// Nullable tip veri türleri, değer türlerinin null değerini alabilmesini sağlar.
// ? operatörü ile bir değer türünü nullable yapabiliriz.
// Nullable türler, değer türlerinin null değerini alabilmesini sağlar.
