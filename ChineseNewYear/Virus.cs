using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNewYear
{
    class Virus
    {
        private int infectionTimeDay;
        private string[] symptoms = new string[8];
        public Virus(int infectionTime = 10)
        {
            infectionTimeDay = infectionTime;
        }

        protected void infection()
        {

        }

    }
}
