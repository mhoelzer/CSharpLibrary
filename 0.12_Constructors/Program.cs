using System;

namespace _Constructors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Character kenn = new Character("kenn",44);
            Character tom = new Character("Tom");
            Character carolyn = new Character("Carolyn", 28, 100);

            GreetUserByUsername(carolyn.Username);

            Console.ReadLine();
        }

        public static void GreetUserByUsername(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
