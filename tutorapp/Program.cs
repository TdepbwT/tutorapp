﻿using System;
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
                                Console.WriteLine($"What is {num1} {op} {num2}?");
                                Console.Write("Enter your answer: ");
                                int answer;
                                while (!int.TryParse(Console.ReadLine(), out answer))
                                {
                                    Console.WriteLine("Invalid input");
                                    Console.Write("Enter your answer: ");
                                }

                                if (Calculate(num1, num2, op) == answer)
                                {
                                    Console.WriteLine("Correct!");
                                    Console.WriteLine("Would you like to: ");
                                    Console.WriteLine("1. Deal 3 cards again");
                                    Console.WriteLine("2. Return to the main menu");
                                    Console.Write("\nEnter your choice: ");
                                    string input2 = Console.ReadLine();
                                    Console.WriteLine();
                                    switch (input2)
                                    {
                                        case "1":
                                            hand = pack.Deal();
                                            num1 = hand[0].Value;
                                            num2 = hand[1].Value;
                                            op = hand[2].Operator;
                                            Console.WriteLine($"What is {num1} {op} {num2}?");
                                            Console.Write("Enter your answer: ");
                                            while (!int.TryParse(Console.ReadLine(), out answer))
                                            {
                                                Console.WriteLine("Invalid input");
                                                Console.Write("Enter your answer: ");
                                            }

                                            if (Calculate(num1, num2, op) == answer)
                                            {
                                                Console.WriteLine("Correct! ");

                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect! The answer is {0} ", Calculate(num1, num2, op));
                                                
                                            }
                                            break;
                                        case "2":
                                            break;
                                        default:
                                            Console.WriteLine("Invalid input. Returning to main menu.");
                                            break;
                                    }
                                }
                               
                                

                               
                            }
                            break;

                        case 2:
                            //quit
                            quit = true;
                            Console.WriteLine("Thank you for using the Math Tutoring Application!");
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
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