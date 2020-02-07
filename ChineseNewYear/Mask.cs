using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNewYear
{
    sealed class Mask
    {
        private int protectionInterest = 50;
        private int protectionTimeHour = 4;
        private Boolean maskLife = true;

        public int ProtectionTime 
        {
            get { return protectionTimeHour; }
            set
            {
                protectionTimeHour = value;
                if (protectionTimeHour <= 0)
                    maskLife = false;
            }
        }
    }
}
