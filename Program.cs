
using System;
// Namespace
namespace NameGame
    {
    // Main class
    class Program
    {
        //Entry Point Method - will not return anything (void)
        // static means that there will not be multiple instances of that class
        static void Main(string[] args)
        {
            // Run GetAppInfo function from below
            GetAppInfo();

            //ask for users name and greet them
            GreetUser();

            
            // allow subsequent games to happen with while loop
            while (true)
            {

                //init correct number to begin the game
                //int correctNumber = 7;

                // create a new random object so that the correct number is random and not fixed
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                // init guess var
                int guess = 0;

                // ask the user to guess a number
                Console.WriteLine("Guess a number between 1 and 10.");

                // if the number they enter does not match we want them to guess again, so this requires a loop
                // while guess is NOT correct
                while (guess != correctNumber)
                {
                    // get users input
                    string input = Console.ReadLine();

                    //error handling in the event the user enters a letter or other character
                    if (!int.TryParse(input, out guess))
                    {

                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number.");

                        // keep going
                        continue;
                    }

                    //change to integer and place in the guess variable
                    guess = Int32.Parse(input);

                    //match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        // print error message when non number is entered
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }
                // output success messsage when they choose correct number
               
                PrintColorMessage(ConsoleColor.Yellow, "Great job. You are CORRECT!");

                // ask user if they want to play again
                Console.WriteLine("Would you like to play again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;

                }else if (answer == "N")  {
                    return;
                }

            } // while true loop ends here
        }
        // create a function to get the app info.
        static void GetAppInfo() {
            // start app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dana L. Brown";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app header info.
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();
        }
        static void GreetUser() {
            //ask for users name and greet them
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game. . .", inputName);
        }
        // function to print color message  
        static void PrintColorMessage(ConsoleColor color, string message) {
            // change text color
            Console.ForegroundColor = color;

            //tell user it is not a numner
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();

        }
    }

}
