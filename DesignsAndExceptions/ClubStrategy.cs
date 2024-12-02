using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public class ClubStrategy : IWeaponStrategy
    {
        public void Attack(IAttackable target)
        {
            Console.WriteLine("The Club swings a heavy attack.");
            target.TakeDamage(25);
        }
    }
}
