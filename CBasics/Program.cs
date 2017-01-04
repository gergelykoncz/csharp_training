using System;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the title of our console window
            Console.Title = "My awesome console title";
            //Make it look like the Matrix
            Console.ForegroundColor = ConsoleColor.Green;
            //Check if we have any command line arguments
            if (args.Length > 0)
            {
                //Note the string formatting syntax here
                //{0} will be substituted by the args[0] value
                Console.Write("Your name is {0}.", args[0]);
            }
            else
            {
                //If not, read a value from the console
                Console.Write("Please enter your name: ");
                //Console.ReadLine will block the execution until the user presses enter
                string name = Console.ReadLine();
                Console.Write("Your name is {0}.", name);
            }

            //Wait for user input before closing
            Console.Read();
        }
    }
}
