using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.App
{
    // camelCase adlandırmayı parametre, değişken
    // PascalCase adlandırmayı sınıf, metot, property
    public class A
    {
    }
    public class MethodExample
    {
        public T AddGeneric<T>(T number1, T number2)
        {
            
            return (dynamic)number1! + (dynamic)number2!;
        }
        public bool EqualsGeneric<T>(T number1, T number2)
        {
            return number1!.Equals(number2);
        }

        public bool CompareGeneric<T>(T number1, T number2) where T : IComparable // IComparable interface'ini implemente eden bir tür olmalı
        {
            return number1!.CompareTo(number2) > 0;
            // CompareTo büyükse 1, eşitse 0, küçükse -1 döner.
        }

        public T CompareGeneric2<T>(T number1, T number2) where T : IComparable 
        {
            return number1!.CompareTo(number2) > 0 ? number1 : number2;
            // Ternary operator : koşul ? doğruysa : yanlışsa
        }

        public int CompareGeneric3<T>(T number1, T number2) where T : IComparable
        {
            return number1!.CompareTo(number2);
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public bool Compare(int number1, int number2)
        {
            return number1 == number2;
        }

        public bool Compare(double number1, double number2)
        {
            return number1 > number2;
        }
    }
}
