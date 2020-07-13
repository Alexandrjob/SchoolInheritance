using System;
using System.Threading;

namespace ChineseNewYear
{
    class Program
    {
        private static Random random = new Random();
        private static CoronaVirus coronaVirus = new CoronaVirus();
        private static Virus virus = new Virus();

        public static void Main()
        {
            int minPercentageOfImmunity = 70;
            int maxPercentageOfImmunity = 100;
            int percentageOfImmunity;

            percentageOfImmunity = random.Next(minPercentageOfImmunity, maxPercentageOfImmunity);
            Chinese chineseMan = new Chinese(percentageOfImmunity);
        
            while (!chineseMan.IsDead)
            {
                LifeCycle(chineseMan);
                Thread.Sleep(500);
            }
        }
        
        private static void LifeCycle(Chinese chineseMan)
        {
            var currentVirus = EvaluateVirus();
            currentVirus.Attack(chineseMan);
        }

        private static Virus EvaluateVirus()
        {
            if (random.Next(1, 3) == 1)
            {
                return virus;
            }
            return coronaVirus;
        }
    }
}
