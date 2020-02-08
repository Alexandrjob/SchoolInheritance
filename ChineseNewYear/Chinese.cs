using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNewYear
{
    sealed class Chinese
    {
        private bool isDead;

        private static Immunity immunity = new Immunity();

        public Chinese(int percentageOfImmunity = 70,bool isInFected = false,string VirusName = null, bool isDead = false)
        {
            this.isDead = isDead;
            immunity.SetVirusName = VirusName;
            immunity.SetIsInFected = isInFected;
            immunity.SetPercentageOfImmunity = percentageOfImmunity;
        }
        public bool SetIsDead
        {
            get { return isDead; }
            set { isDead = value; }
        }
        public void DefenseImmunity(int damage)
        {
            immunity.Defence(damage, this);
        }

        public override string ToString()
        {
            string chineseCondition;
            chineseCondition = string.Format("[ Immunity: {0}%; isInfected: {1}; Virusname: {2}; isDead: {3} ]",
                immunity.SetPercentageOfImmunity, immunity.SetIsInFected, immunity.SetVirusName, isDead);

            return chineseCondition;
        }
    }
}
