using System;

namespace _Overloading
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player bob = new Player();
            bob.Attack();
            // if you see .Attack(+1 overload) or w/e and can call ether of the diff stuff
            // no limit to overloads
            bob.Attack(5);
            bob.Attack(7, "Dusty Stick");

            Console.ReadLine();
        }
    }
}
