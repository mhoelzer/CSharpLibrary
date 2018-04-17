using System;

namespace _ClassChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hotel california = new Hotel();
            // substantiaterd hotel class and will go up into memory called california
            california.RoomNum = "50";
            california.IsAvailable = true;
            california.CheckAvailability();

            Console.ReadLine();
        }
    }
}
