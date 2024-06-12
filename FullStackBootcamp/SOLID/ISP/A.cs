using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal class A(IReadRepository readRepository)
    {
        public void Read()
        {
            readRepository.Read(1);
        }
    }
}
