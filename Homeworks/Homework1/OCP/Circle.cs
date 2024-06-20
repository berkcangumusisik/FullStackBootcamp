using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.OCP
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle()
        {
            
        }


        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
