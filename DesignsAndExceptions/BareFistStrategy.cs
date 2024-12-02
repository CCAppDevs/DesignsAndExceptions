using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public class BareFistStrategy : IWeaponStrategy
    {
        public void Attack(IAttackable target)
        {
            Console.WriteLine("Taking a wild swing... The hit is not very effective!");
            target.TakeDamage(1);
        }
    }
}
