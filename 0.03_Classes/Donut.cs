using System;
namespace _Classes
{
    public class Donut
    {
        // properties
        public string Type { get; set; }
        public bool HasCream { get; set; }
        public decimal Price { get; set; }
        public bool HasPoison { get; set; }

        // Methods; private = not accessible outside of the class
        public void PrintDonutType()
                 // ^^^ method signature
        {
            Console.WriteLine(this.Type);
        }
        // function printDonutType(){
        //      console.log(this.....)}
    }
}
