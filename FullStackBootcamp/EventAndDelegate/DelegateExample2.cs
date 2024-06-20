using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public enum CalculatorType
    {
        Add,
        Multiply,
        Subtraction,
        Division
    }

    public delegate int Calculator(int a, int b);

    internal class DelegateExample2
    {
        public int GoodCalculate(int a, int b, Calculator calculator)
        {
            return calculator.Invoke(a, b);
        }

        public int Calculate(int a, int b, CalculatorType calculateType)
        {
            var result = 0;
            switch (calculateType)
            {
                case CalculatorType.Add:
                    result = a + b;
                    break;
                case CalculatorType.Multiply:
                    result = a * b;
                    break;
                case CalculatorType.Subtraction:
                    result = a - b;
                    break;
                case CalculatorType.Division:
                    result = a / b;
                    break;
                default:
                    break;
            }
            return result;
            
        }
    }
}

