using System;

namespace ChineseNewYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Chinese chineseMan = new Chinese(80, true, false, false);
            
            Console.WriteLine(chineseMan);
            //Console.Read();
        }
    }
}
