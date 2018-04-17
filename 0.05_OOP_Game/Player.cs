using System;
namespace _OOP_Game
{
    public class Player : Character
    // PROPERTIES. will inherit some from character
    {
        //Constructor
        public Player(string firstName, int playerLevel, int currentPowerLevel, bool lowPower, string name, string type)
        {
            this.PlayerName = firstName;
            this.Level = playerLevel;
            this.CurrentPower = currentPowerLevel;
            this.IsLowOnPower = lowPower;
            this.Name = name;
            this.Type = type;
        }



        //paul.IsLowOnPower = true;
        //    paul.Name = "Paul";
        //    paul.Type = "Human";



        //Properties
        public string PlayerName { get; set; }
       
    }
}
