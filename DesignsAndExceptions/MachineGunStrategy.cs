using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public class MachineGunStrategy : IWeaponStrategy
    {
        public void Attack(IAttackable target)
        {
            Console.WriteLine("The machine gun starts to spray!");

            for (int i = 0; i < 20; i++)
            {
                var rand = new Random();

                if (rand.NextDouble() > 0.5)
                {
                    target.TakeDamage(5);
                }
            }
        }
    }
}
