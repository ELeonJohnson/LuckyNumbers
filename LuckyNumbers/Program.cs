using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaring global variables and assigning values
            string exit = " ";
            int usersLowestNumber = 0;
            int usersHighestNumber = 0;
            int usersLuckyNumbers = 0;
            int gameWinningNumbers = 0;
            int jackpot = 360000000;
            int correctNumberGuess = 0;
            double usersTotalWinnings = 0;


            
            do
            {

                //introduction to the game
                Console.WriteLine("Hello there and welcome to Lucky Numbers where you can win a fortune!");
               
                //displaying the jackpot amount to the user
                Console.WriteLine("Current Jackpot: " + jackpot);
                
                //asking for the user's lowest number 
                Console.WriteLine("Please give me a starting number for your lowest number.");
                usersLowestNumber = int.Parse(Console.ReadLine());
                
                //asking for the user's highest number
                Console.WriteLine("Great, please enter a second number for your highest number.");
                usersHighestNumber = int.Parse(Console.ReadLine());


                //declaring an integer array for the user's lucky numbers
                int[] usersLuckyNumbersArr = new int[6];

               
                for (int i = 0; i < usersLuckyNumbersArr.Length; i++)
                {   
                    //asking for the user's 6 lucky numbers
                    Console.WriteLine("Please choose 6 lucky numbers:");
                    usersLuckyNumbers = int.Parse(Console.ReadLine());

                    // while loop that checks if the user's input is valid for the number range they set in the game
                    while (usersLuckyNumbers < usersLowestNumber || usersLuckyNumbers > usersHighestNumber)
                    {
                        Console.WriteLine("I'm sorry, that is an invalid number.");
                        Console.WriteLine("Please enter a valid number.");
                        usersLuckyNumbers = int.Parse(Console.ReadLine());

                    }

                }


                //declaring an integer array for the winning numbers
                int[] gameWinningNumbersArr = new int[6];

                //Random number method
                Random numbers = new Random();

               for (int i = 0; i < gameWinningNumbersArr.Length; i++)
                {   
                    // looping through the range of numbers the user set to display random numbers and assign them to a gameWinningNumbers variable
                    int randomNumbers = numbers.Next(usersLowestNumber, usersHighestNumber);
                    Console.WriteLine("Lucky Number: " + randomNumbers);
                    gameWinningNumbers = randomNumbers;


                    //keeping count on how many numbers the user guessed right and displaying it to them
                    if (usersLuckyNumbers == gameWinningNumbers)
                    {
                        correctNumberGuess++;
                        Console.WriteLine("You guessed " + correctNumberGuess + " numbers correctly!");

                    }
                }

               //logic that divides the jackpot up based on how many correct numbers the user had and displaying their jackpot

                if (correctNumberGuess == 1)
                {
                    usersTotalWinnings = jackpot / 6;
                    Console.WriteLine("You won $" + usersTotalWinnings + "!");
                }
                else if (correctNumberGuess == 2)
                {
                    usersTotalWinnings = jackpot / 5;
                    Console.WriteLine("You won $" + usersTotalWinnings + "!");
                }
                else if (correctNumberGuess == 3)
                {
                    usersTotalWinnings = jackpot / 4;
                    Console.WriteLine("You won $" + usersTotalWinnings + "!");
                }
                else if (correctNumberGuess == 4)
                {
                    usersTotalWinnings = jackpot / 3;
                    Console.WriteLine("You won $" + usersTotalWinnings + "!");
                }
                else if (correctNumberGuess == 5)
                {
                    usersTotalWinnings = jackpot / 2;
                    Console.WriteLine("You won $" + usersTotalWinnings + "!");
                }
                else if (correctNumberGuess == 6)
                {
                    usersTotalWinnings = jackpot;
                    Console.WriteLine("You won $" + usersTotalWinnings + "!");
                }
                else
                {
                    Console.WriteLine("You won $" + usersTotalWinnings + "!");
                }

                // seeing if the user would like to play the game again or exit
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("Type [y/n].");
                exit = Console.ReadLine().ToLower();

                if ( exit == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                }

            } while (exit != "n");







        }
        
        
    }
}
