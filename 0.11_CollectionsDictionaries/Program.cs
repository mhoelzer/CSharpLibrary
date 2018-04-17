using System;
using System.Collections.Generic;

namespace _CollectionsDictionaries
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // bronze
            // what it is <type, type>
            Dictionary<string, string> bestPicture = new Dictionary<string, string>()
            {
                {"2000", "Gladiator"},
                {"2001", "A Beautiful Mind"},
                {"2002", "Chicago"},
                {"2003", "The Lord of the Rings: The Return of the King"},
                {"2004", "Million Dollar Baby"},
                {"2005", "Crash"}
            };

            foreach (KeyValuePair<string, string> pair in bestPicture)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }


            Console.WriteLine("--------------");


            // silver
            var bPNominees = new Dictionary<string, string[]>()
            {
                {"2000", new string[]{"movie1", "movie2"}},
                {"2001", new string[]{"movie1", "movie2"}},
                {"2002", new string[]{"movie1", "movie2"}},
                {"2003", new string[]{"movie1", "movie2"}},
                {"2004", new string[]{"movie1", "movie2", "movie3"}},
                {"2005", new string[]{"movie1", "movie2"}}
            };

            foreach (KeyValuePair<string, string[]> pair in bPNominees)
            {
                // FIGURE OUT THE VALUEEEE
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            // his pair.value doesnt finish going through all 


            // gold

            // putting stuff in readLine string adn puttin gin balueforkey and it gets printed. 
        }
    }
}


//// bronze
//var AAWinners = new List<string>();
//AAWinners.Add("Quincy");
            //AAWinners.Add("Spencer");
            //AAWinners.Add("Xaaron");

            //foreach (var winner in AAWinners)
            //// usually dont name "member" or w/e as pural
            //{
                //Console.WriteLine(winner);

//// bronze
//var AAWinners = new List<KeyValuePair<int, string>>();
//AAWinners.Add(new KeyValuePair<int, string>(2000, "Gladiator"));
            //AAWinners.Add(new KeyValuePair<int, string>(2001, "A Beautiful Mind"));
            //AAWinners.Add(new KeyValuePair<int, string>(2002, "Chicago"));
            //AAWinners.Add(new KeyValuePair<int, string>(2003, "The Lord of the Rings: The Return of the King"));
            //AAWinners.Add(new KeyValuePair<int, string>(2004, "Million Dollar Baby"));
            //AAWinners.Add(new KeyValuePair<int, string>(2005, "Crash"));

            //foreach (var winner in AAWinners)
            //{
            //    Console.WriteLine(winner);
            //}


//Dictionary<string, List<string>> bPNominees = new Dictionary<string, List<string>>()
            //{
            //    {"2000", <List<string>>},
            //    {"2001", "A Beautiful Mind"},
            //    {"2002", "Chicago"},
            //    {"2003", "The Lord of the Rings: The Return of the King"},
            //    {"2004", "Million Dollar Baby"},
            //    {"2005", "Crash"}
            //};

            //foreach (KeyValuePair<string, string> pair in bPNominees)
            //{
            //    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            //}