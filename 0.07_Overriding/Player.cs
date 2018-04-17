using System;
namespace _Overriding
{
    public class Player : Character
    {
        // method, not property; want the same method but want diff message but might get confused with thes ame keyword...
        // OVERRIDE: at top of parent class (character) --> make virtual; below --> a subclass and becomes override
        public override void HealAlly()
        {
            Console.WriteLine("The player healed the other player.");
        }
    }
}
