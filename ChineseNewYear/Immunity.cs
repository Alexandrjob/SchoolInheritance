using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNewYear
{
    class Immunity
    {
        private bool isinFected;
        private string VirusName;
        private int percentageOfImmunity;
        private readonly int extaDamage = 2;
        
        public void Defence(int damage, Chinese chinese)
        {
            if (isinFected)
                damage += extaDamage;

            percentageOfImmunity -= damage;
            if (percentageOfImmunity <= 0 | chinese.SetIsDead)
            {
                percentageOfImmunity = 0;
                chinese.SetIsDead = true;
            }
            else if (percentageOfImmunity <= 40)
            {
                isinFected = true;
            }
        }

        public bool SetIsInFected 
        {
            get { return isinFected; }
            set { isinFected = value; }
        }

        public int SetPercentageOfImmunity
        {
            get { return percentageOfImmunity; }
            set { percentageOfImmunity = value; }
        }

        public string SetVirusName
        {
            get { return VirusName; }
            set { VirusName = value; }
        }
    }
}
