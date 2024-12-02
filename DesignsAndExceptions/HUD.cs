using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public class HUD : ISubscriber
    {
        public void Update(int currentHealth)
        {
            Console.WriteLine($"Current Health: {currentHealth}");
        }
    }
}
