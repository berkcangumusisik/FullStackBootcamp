using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    internal class BuiltInDelegate
    {
        public BuiltInDelegate()
        {
            Action<int, int> action = (a, b) => Console.WriteLine(a + b); // void (parametreler) : Action delegate yani void dönen bir metodu temsil eder.
            Action <int, int, string> action2 = (a, b, c) => Console.WriteLine(a + b);
            Action<int, int> action3 = ActionMethod1;

            Predicate<string> predicate = (name) => name == "Asp.Net Core"; // bool (parametreler) : Predicate delegate yani bool dönen bir metodu temsil eder.
            Predicate<string> predicate2 = PredicateMethod;

            Func<double, double, int> func = (a, b) =>(int)(a + b); // Func <T1, T2, TResult> : Geriye dönen değeri olan bir metodu temsil eder. Mesela int dönen bir metodu temsil eder.
        }

        void ActionMethod1(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        bool PredicateMethod(string name)
        {
            return name == "Asp.Net Core";
        }
    }
}
