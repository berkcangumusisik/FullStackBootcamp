using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ISP
{
    public class RobotWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot çalışıyor.");
        }
    }
}
