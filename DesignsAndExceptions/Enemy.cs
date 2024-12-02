using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public class Enemy : ISubscriber, IAttackable
    {
        public void TakeDamage(int hitAmount)
        {
            Console.WriteLine("The Enemy Takes the hit!");
        }

        public void Update(int currentHealth)
        {
            Console.WriteLine($"The goblin sees the player is at {currentHealth} and goes berzerk");
        }
    }
}
