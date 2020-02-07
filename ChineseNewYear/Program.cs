using System;
using System.Timers;

namespace ChineseNewYear
{
    class Program
    {
        private object[] Population = new object[100];
        private static Random random = new Random();

        public static void Main(string[] args)
        {
            //Это экзэмпляр класса Китайца
            Chinese chineseMan = new Chinese(random.Next(0, 100), true, false, false);
            // Вот он
            chineseMan
            
            Console.WriteLine(chineseMan);



            using (Timer timer = new Timer())
            {
                
                timer.Interval = 3000;
                timer.Elapsed += LifeCycle;
                timer.Start();
                //Ставим основной поток на ожидание, т.к. таймер исполняется в 
                //отдельном потоке и не препятствует завершению основного потока.
                Console.ReadLine();
            }
        }
        
        private static void LifeCycle(object source, ElapsedEventArgs e)
        {
            Chinese chineseMan = new Chinese(random.Next(0,100), true, false, false);
            
            Console.WriteLine(chineseMan);
        }
    }
}
