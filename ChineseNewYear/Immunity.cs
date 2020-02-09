using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNewYear
{
    class Immunity
    {
        private readonly int extaDamage = 2;
        private int percentageOfImmunity;

        public bool IsInFected { get; set; }
        public Virus NameInfactedVirus { get; set; }
        public int PercentageOfImmunity
        {
            get { return percentageOfImmunity; }
            set
            {
                if (value < 0)
                { 
                    percentageOfImmunity = 0;
                    
                }
                else percentageOfImmunity = value;
            }
        }
        
        public Immunity(int percentageOfImmunity, Virus virus, bool isInfected)
        {
            PercentageOfImmunity = percentageOfImmunity;
            NameInfactedVirus = virus;
            IsInFected = isInfected;
        }

        public void DecreaseImmunity(int percent, Chinese chinese)
        {
            if (NameInfactedVirus != null)
            {
                PercentageOfImmunity -= NameInfactedVirus.Damage;
            }
            else
            {
                PercentageOfImmunity -= percent;
            }

            if (PercentageOfImmunity == 0)
                chinese.KillTheChinese();
        }

        public void Defence(int damage, Chinese chinese, Virus virus)
        {
            int currentDamage = damage;

            if (IsInFected)
                currentDamage += extaDamage;

            DecreaseImmunity(currentDamage, chinese);
            
            if (PercentageOfImmunity <= 40 && NameInfactedVirus == null)
            {
                IsInFected = true;
                NameInfactedVirus = virus;
            }
        }
    }
}
