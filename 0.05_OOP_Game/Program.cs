using System;

namespace _OOP_Game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Start the game
            Console.WriteLine("Welcome soldier. What is your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine("What would you like your gamername to be?");
            string gamerName = Console.ReadLine();


            Console.WriteLine("What is your type? \n" +
                    "1: Barbarian\n" +
                    "2: Wizard\n" +
                    "3: Monk\n"
                );

            int parseType = int.Parse(Console.ReadLine());

            Console.WriteLine(gamerName);

            //Player choices 

            //Fight

            //Deal with points

            //Death



            Player paul = new Player("zedisdead", 100, 10, true, "Paul", "Human");

            Creature zed = new Creature("hurtlocker", 100, 10, true, "Zed", "HorseMange");
        }
    }
}
