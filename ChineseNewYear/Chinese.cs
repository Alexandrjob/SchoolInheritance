using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNewYear
{
    sealed class Chinese
    {
        private int percentageOfImmunity;
        private bool isDead;
        private bool isinFected;
        private bool isMaskDressed;

        public Chinese(int percentageOfImmunity = 70,bool isMaskDressed = false,bool isDead = false,bool isInFected = false)
        {
            
            this.isDead = isDead;
            this.isinFected = isInFected;
            this.isMaskDressed = isMaskDressed;
            SetPercentageOfImmunity = percentageOfImmunity;
        }



        public int SetPercentageOfImmunity
        {
            get { return percentageOfImmunity; }
            set
            {
                percentageOfImmunity = value;
                if(percentageOfImmunity <= 0)
                {
                    isDead = true;
                }
                if(percentageOfImmunity <= 30)
                {
                    isinFected = true;
                }
            }
        }



        public override string ToString()
        {
            string myState;
            myState = string.Format("[Immunity: {0}%; isMaskDressed: {1}; isInfected: {2}; isDead: {3} ]", percentageOfImmunity, isMaskDressed, isinFected, isDead);
            return myState;
        }
    }
}
