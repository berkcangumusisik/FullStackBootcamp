using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.LSP
{
    public class Car: Transportation
    {
        public override void Start()
        {
            Console.WriteLine("Araba Çalıştı.");
        }
    }
}
