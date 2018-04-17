using System;
namespace _OOP_Game
{
    public class Creature : Character
    // PROPERTIES. will inherit from character
    {
        //Constructor
        public Creature(string firstName, int playerLevel, int currentPowerLevel, bool lowPower, string name, string type)
        {
            this.CreatureName = firstName;
            this.Level = playerLevel;
            this.CurrentPower = currentPowerLevel;
            this.IsLowOnPower = lowPower;
            this.Name = name;
            this.Type = type;
        }

        public string CreatureName { get; set; }
    }
}
