using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.LSP
{
    public class TransportationManager
    {
        public void StartTransportation(Transportation transportation)
        {
            transportation.Start();
        }
    }
}
