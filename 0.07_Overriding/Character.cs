using System;
namespace _Overriding
{
    public class Character
    {
        //can put in any order, but conventions usually go over properties 

        // method, not property 
        // virtual is main class 
        public virtual void HealAlly()
        {
            Console.WriteLine("The character healed the ally.");
        }
    }
}
