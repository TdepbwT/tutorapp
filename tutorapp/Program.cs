using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Tutoring Application!");

            // create a pack of cards
            pack pack = new pack(52);

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nPlease Choose an option: ");
                Console.WriteLine("1. Start a new game");
                Console.WriteLine("2. Quit");
                Console.WriteLine("\nChoose an option number: ");

                //get user input
                string input = Console.ReadLine();
                int choice;

                // try to convert the input to an integer
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            //deal 3 cards and create an equation
                            List<Card> hand = pack.Deal();
                            if (hand.Count == 3)
                            {
                                
                                // create an equation
                                int num1 = hand[0].Value;
                                int num2 = hand[1].Value;
                                string op = hand[2].Operator;
                                int answer = Calculate(num1, num2, op);

                                Console.WriteLine($"What is {num1} {op} {num2}?");
                                string input2 = Console.ReadLine();
                                int guess;
                                if (int.TryParse(input2, out guess))
                                {

                                    if (guess == answer)
                                    {
                                        Console.WriteLine("Correct!");

                                    }
                                    else
                                    {
                                        Console.WriteLine($"Incorrect! The answer was {answer}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                }
                                

                               
                            }
                            break;

                        case 2:
                            //quit
                            quit = true;
                            Console.WriteLine("Thank you for playing!");
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number");
                }
                    
            }
           

        }

        private static int Calculate(int num1, int num2, string op)
        {
            int answer = 0;
            switch (op)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
            }
            return answer;
        }
    }

}