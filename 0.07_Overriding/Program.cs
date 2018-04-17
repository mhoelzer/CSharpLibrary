using System;

namespace _Overriding
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Character 
            Character quincy = new Character();
            quincy.HealAlly();

            // Player
            Player bob = new Player();
            // will HealAlly be available on jenn/a new player? yes b/c the parent class is character and player inherits stuff from cjaarcter
            bob.HealAlly();

            // Enemy
            Enemy gluten = new Enemy();
            gluten.HealAlly();

            Console.ReadLine();
        }
    }
}
