using System;
namespace _Overriding
{
    public class Enemy : Character
    {
        public override void HealAlly()
        {
            Console.WriteLine("The enemy healed their ally.");
        }
    }
}
