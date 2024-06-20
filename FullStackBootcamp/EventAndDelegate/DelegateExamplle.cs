using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    internal class DelegateExample
    {
        

        internal void Method1(int a , int b, Operator operators)
        {
            double c = 20;
            double d = 30;
        }
    }
}


/*
 Delegate Nedir?
    - Delegate, bir metodun nasıl çağrılacağını belirten bir türdür.
    - Delegate, bir metodun referansını tutan bir türdür.
    - Yöntemlerimize bir nesne gibi davranmamızı sağlar.
    - Tür açısından güvenli bir şekilde yöntem çağrıları yapmamızı sağlar.
    - <modifer> delegate <return type> <delegate name> (<parameters>);

 */