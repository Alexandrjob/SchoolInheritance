using System;
using System.Timers;

namespace ChineseNewYear
{
    class Program
    {
        private static readonly int minPercentageOfImmunity = 0;
        private static readonly int maxPercentageOfImmunity = 100;
        private static int percentageOfImmunity;

        private static Random random = new Random();
        private static Chinese chineseMan;
        private static CoronaVirus coronaVirus = new CoronaVirus();
        private static Virus virus = new Virus();


        public static void Main(string[] args)
        {
            Program program = new Program();

            //chineseMan = new Chinese(percentageOfImmunity, false);
            percentageOfImmunity = random.Next(minPercentageOfImmunity, maxPercentageOfImmunity);
            chineseMan = new Chinese(percentageOfImmunity);

            using (Timer timer = new Timer())
            {   
                
            
                timer.Interval = 800;
                timer.Elapsed += program.LifeCycle;
                timer.Start();
                //Ставим основной поток на ожидание, т.к. таймер исполняется в 
                //отдельном потоке и не препятствует завершению основного потока.
                Console.ReadLine();
            }
        }
        
        private void LifeCycle(object source, ElapsedEventArgs e)
        {
            
            
            if(GenerateVirus() == 1)
                virus.Infect(chineseMan);
            else coronaVirus.Infect(chineseMan);

            Console.WriteLine(chineseMan);
        }

        private static int GenerateVirus()
        {
            return random.Next(1, 2);
        }
    }
}
