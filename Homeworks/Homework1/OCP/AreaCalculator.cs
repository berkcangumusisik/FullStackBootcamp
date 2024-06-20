using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.OCP
{
    public class AreaCalculator
    {
        public double CalculateArea(IEnumerable<Shape> shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }
            return totalArea;
        }
    }
}
