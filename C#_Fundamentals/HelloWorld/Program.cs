using System;
using HouseFunction;
// This is a comment

/*
    Will be a comment
    Even this
    - We use PascelCase for the most part and that means naming artifacts as EverythingWillBeCapitalized
    - We use camelCase for naming fields and that means naming artifacts as onlyOnceYouHaveALowerCaseWordAtTheBeginning
*/

namespace HelloWorld
{
    class Program
    {
        /*
            - Main method is the first method that will be called/run. (The compiler will look for this method)
            - static means, I don't have to instantiate the program class to use that method 
            - void, the method will not give anything back
        */
        static void Main(string[] args)
        {
            //It will print the test inside the parenthesis onto the terminal
            Console.WriteLine("Hello World!");

            // This is if you don't make the method static you have to insantiate it
            // Program test = new Program(); //This will instantiate the obj
            // test.Example();

            Program.Example();

            House Stephen = new House();
            Stephen.MiceName = "Jerry";
            Stephen.Owner = "Colin";
            Console.WriteLine(Stephen.MiceName);
            Console.WriteLine(Stephen.Owner);



            Console.WriteLine("Your Name?");
            string s = Console.ReadLine();
            Console.WriteLine("You are so cool " + s);
        }

        public static int Example()
        {
            return 10;
        }
    }
}
