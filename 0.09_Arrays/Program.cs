using System;

namespace _Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // array of high scores then for each loop
            // brackets  = new arrayname[] {indecies}
            int[] scores = new int[] { 99, 87, 66, 22 };
            // the score could just be s or w/e you want 
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            // Arrays are strongly typed. you ant add a string to an int array and vice versa. more common to see a list over an array 
            // arrays cant grow or shrink in size once initialized. arrays are immutable (can't remove or cant add) in c#
            // ve aware of index offset --> the array starts a 0. to access it we need to use that access
            // scores[4] = 5; --> this won't work.
            // scores[4] = "yo";  --> this won't work. 

            Console.ReadLine();

        }
    }
}
