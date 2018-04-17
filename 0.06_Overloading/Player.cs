using System;
namespace _Overloading
{
    public class Player
    {
        // implicit consttructor is public Player()
        public void Attack()
        {
            // hey they attacked
            Console.WriteLine("The player attacked for some points");
        }

        // methods can't have the same name unless you add a parameter
        public void Attack(int points)
        {
            // pass in an arguement; hey they attacked with this many points
            Console.WriteLine("The player attacked for {0} points", points);
        }

        public void Attack(int points, string weapon)
        {
            // the 0 spot is for the first spot in the "array", etc
            Console.WriteLine("The player attacked for {0} points using a {1}", points, weapon);
        }

    }
}
