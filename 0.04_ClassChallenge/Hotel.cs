using System;
namespace _ClassChallenge
{
    public class Hotel
    {
        public string RoomNum { get; set; }
        public bool IsAvailable { get; set; }
        public string NumBeds { get; set; }

        // Method
        public void PrintRoomNum()
        {
            Console.WriteLine("Hello, your room number is {0}", RoomNum);
                                    // this.RoomNum works as well ^^^
        }

        public void CheckAvailability()
        {
            if (IsAvailable)
                Console.WriteLine("{0} is available", RoomNum);
            else
                Console.WriteLine("Doesn't look like {0} is available", RoomNum);
        }
    }
}
