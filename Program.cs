using System;

//Namespace
namespace csharp
{
    //Class Name
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //start here let's code !
           
            int age = 23;
            string appName = "DotNet";
            string appVersion = "1.0.0";
            string appAuthor = "Richard Cacuango";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}, {3}",appName,appVersion,appAuthor,age);

            //Reset color
            Console.ResetColor();
            //Ask user name
            Console.WriteLine("What's your name?");
            //Get user input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}",input);

        }
    }
}
