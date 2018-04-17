using System;
namespace _Constructors
{
    // if it is sealed class Character, you cant inherit from a sealed class (can be another form of encapsulation)
    // abstract class: 
    public class Character
    {
        // there i s an implied constructor by default: public Character()
        public Character(string username)
        {
            // the "this." isn't neeeded and is just impolied 
            // this.Username = username;
            Username = username;
        }
        public Character(string username, int age)
        {
            this.Username = username;
            this.Age = age;
        }
        public Character(string username, int age, int health)
        {
            this.Username = username;
            this.Age = age;
            this.Health = health;
        }
        // Propterties 

        public int Age { get; set; }
        public string Username { get; set; }
        public int Health { get; set; }

    }
}
