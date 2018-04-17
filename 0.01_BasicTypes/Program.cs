using System;

namespace _BasicTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 0;
            short sh = 32767;
            // ^^^ this is as high as it can go
            byte by = 255;
            // ^^^ this is as high as it can go
            string st = "Hello World";

            char c = 'i';
            char num = '5';

            bool isTired;
            // ^^^ he declared a var but hasnt initizlised it
            isTired = true;
            // ^^^ initialized

            double doub = 7.80;
            float f = 8.75f; // the f stands for float
            long l = 7000; // youtube used this for # of minutes viewed then got it messed up 

            int? n = null;

            Console.WriteLine(num);

            if(isTired)
                Console.WriteLine("let me sleep");
            // no curly braces needed; if single line after conditional, dont need curlies

            Console.ReadLine();
        }
    }
}
