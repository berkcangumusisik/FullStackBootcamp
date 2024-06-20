using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Gaming
{
    public class Enemy
    {
        public void OnHealthChanged(object sender, HealthChangedEventArgs e)
        {
            Console.WriteLine($"Düşmanın canı azaldı. Yeni can: {e.NewHealth}");
        }
    }
}
