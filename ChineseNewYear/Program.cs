using System;
using System.Timers;
using Timers = System.Timers;

namespace ChineseNewYear
{
    class Program
    {
        //private static Timer _timer;
        private static Timers.Timer _timer;

        public static void Main(string[] args)
        {
            /*_timer = new Timers.Timer
            {
                AutoReset = true,
                Interval = 1000,
                Enabled = true
            };
            _timer.Elapsed += LifeCycle;
            _timer.Start();
            */
            using (Timer timer = new Timer())
            {
                timer.Interval = 2000;//интервал задается в миллисекундах
                timer.Elapsed += LifeCycle;
                timer.AutoReset = true;
                timer.Start();
                //Ставим основной поток на ожидание, т.к. таймер исполняется в 
                //отдельном потоке и не препятствует завершению основного потока.
                //Console.ReadLine();
            }

            //Chinese chineseMan = new Chinese(80, true, false, false);

            //Console.WriteLine(chineseMan);
            //Console.Read();
        }

        private static void LifeCycle(object source, ElapsedEventArgs e)
        {
            Chinese chineseMan = new Chinese(80, true, false, false);

            Console.WriteLine(chineseMan);
        }
    }
}
