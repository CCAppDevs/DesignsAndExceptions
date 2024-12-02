﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public interface IWeaponStrategy
    {
        public void Attack(IAttackable target);
    }
}