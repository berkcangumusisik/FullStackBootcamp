using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Gaming
{
    public class Player
    {
        public void OnHealthChanged(object sender, HealthChangedEventArgs e)
        {
            if(e.NewHealth == 0)
            {
                Console.WriteLine("Oyuncu öldü.");
            }
            else
            {
                Console.WriteLine($"Oyuncunun canı azaldı. Yeni can: {e.NewHealth}");
            }
        }

    }
}
