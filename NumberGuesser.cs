/* Angel Orellana
 * 
 * NUMBER GUESS VERSION 1.0
 * 
 * CREATED 06 / 01 /2018
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            getAppInfo(); //run getAppInfo function
            Greeting(); //run getUserInfo function


            while (true)
            {
                //Answer that is randomly generated with Random object
                Random randNum = new Random();

                //Correct answer with a random value between 1 - 10
                int correctNum = randNum.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");


                //Game loop, compares guesses to correctNumber
                while (guess != correctNum)
                {
                    //Get user input

                    string userGuess = Console.ReadLine();


                    if (!int.TryParse(userGuess, out guess))
                    {

                        PrintColor(ConsoleColor.Red, "Please use an actual number");

                        continue;


                    }

                    //Cast to int to compare guess
                    guess = Int32.Parse(userGuess);

                    if (guess != correctNum)
                    {

                        PrintColor(ConsoleColor.Red, "INCORRECT PLEASE GUESS AGAIN");

                    }

                    else if(guess == correctNum)
                    {
                        PrintColor(ConsoleColor.Yellow, "Correct you WIN!!");

                    }




                }


                PrintColor(ConsoleColor.Green, "Would you like to play again? [Y or N]");

                //Read user answer, make input uppercase regardless of case input
                string answer = Console.ReadLine().ToUpper();


                if (answer == "Y")
                {
                    continue;

                }

                else if(answer == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    return;

                }

                else
                {
                    return;

                }
        


            }

        }

        static void getAppInfo()
        {
            //Initial Static Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Angel Orellana";


            //Changes console text color
            Console.ForegroundColor = ConsoleColor.Green;


            //Display following line
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Resets Console color
            Console.ResetColor();


        }

        static void Greeting()
        {

            Console.WriteLine("What is your name?");
            //Variable awaiting input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);

        }

        //Print color message

        static void PrintColor(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();

        }
    }
}
