using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNewYear
{
    class Virus
    {
        private int damage = 2;

        public virtual void Infect(Chinese chinese)
        {
            chinese.DefenseImmunity(damage);
        }

    }
}
