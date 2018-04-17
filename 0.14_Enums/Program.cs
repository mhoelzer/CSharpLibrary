using System;

namespace _Enums
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // dataType dataTypeName = w/e
            // int x = 40; 

            // this is now a type we can use
            Weekday day = Weekday.Wednesday;

            switch (day)
            {
                case Weekday.Monday:
                    Console.WriteLine("Today sucks");
                    break;
                case Weekday.Tuesday:
                    Console.WriteLine("Toot toot");
                    break;
                case Weekday.Wednesday:
                    Console.WriteLine("Hump day");
                    break;
                case Weekday.Thursday:
                    Console.WriteLine("fsjknd");
                    break;
                case Weekday.Friday:
                    Console.WriteLine("Rebecca Black Is God(C)(R)(TM)");
                    break;
                case Weekday.Saturday:
                    Console.WriteLine("Best Day");
                    break;
                case Weekday.Sunday:
                    Console.WriteLine("WHYYY");
                    break;
            }
            Console.ReadLine();
        }
    }


    enum Weekday
    {
        // it automatically defaults to 0 
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3, 
        Friday = 4,
        Saturday = 5, 
        Sunday = 6
    }
}
