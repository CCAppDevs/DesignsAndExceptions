using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public class BowStrategy : IWeaponStrategy
    {
        public void Attack(IAttackable target)
        {
            Console.WriteLine("Taking aim.... The bow shoots from a distance!");
            target.TakeDamage(10);
        }
    }
}
