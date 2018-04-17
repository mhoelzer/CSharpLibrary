using System;
using System.Collections.Generic;

namespace _CollectionsLists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var classList = new List<string>();
            classList.Add("Quincy");
            classList.Add("Spencer");
            classList.Add("Xaaron");

            foreach(var member in classList)
                // usually dont name "member" or w/e as pural
            {
                Console.WriteLine(member);
            }


            var fruits = new List<string>()
            {
                "Banana", "Mango", "Pineapple", "Jackfruit", "Breadfruit"
            };
            Console.WriteLine(fruits.Capacity);


            // .Capacity is a property of List; will show size of list; max it can hold at a time
            Console.WriteLine(classList.Capacity);
            Console.ReadLine();
        }
    }
}
