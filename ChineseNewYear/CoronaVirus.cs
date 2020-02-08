using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNewYear
{
    sealed class CoronaVirus : Virus
    {
        private int damage = 3;

        public override void Infect(Chinese chinese)
        {
            
            chinese.DefenseImmunity(damage);
        }
    }
}
