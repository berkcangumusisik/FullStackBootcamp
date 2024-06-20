using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ISP
{
    public class HumanWorker : IWorker, ISleeper
    {
        public void Work()
        {
            Console.WriteLine("İnsan çalışıyor.");
        }

        public void Sleep()
        {
            Console.WriteLine("İnsan Uyuyor.");
        }
    }
}
