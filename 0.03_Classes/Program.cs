using System;

namespace _Classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // instance of a new class
            Donut mattsDonut = new Donut();
            mattsDonut.Type = "Glazed";
            mattsDonut.HasCream = false;
            mattsDonut.Price = 10.99m;
            mattsDonut.HasPoison = false;

            // another new class
            Donut michellesDonut = new Donut();
            michellesDonut.Type = "all of the donuts except plain";
            michellesDonut.HasCream = true;

            // print to the console/terminal
            Console.WriteLine(mattsDonut.Type);
            Console.WriteLine(michellesDonut.Type);
            Console.WriteLine(michellesDonut.HasCream);

            // speaching lmao
            // SpeechSynthesizer speak = new SpeechSynthesizer();
            // speak.Speak(michellesDonut.Type);
                 // ^^^ Speak is a method in this class

            // calling a method
            mattsDonut.PrintDonutType();
                  // ^^^ the . accessor; gives us access to grab stuff
            michellesDonut.PrintDonutType();
           
            Console.ReadLine();
        }
    }
}
