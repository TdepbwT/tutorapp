using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorapp
{
    public class tutorial
    {
        public void DisplayInstructions() // displaying the instructions
        {
            Console.WriteLine("Welcome to the Math Tutoring Application!");
            Console.WriteLine("You will be dealt 3 cards - two numbers and an operator card. They will combine to form an equation.");
            Console.WriteLine("You will then be prompted to provide the correct answer to the equation.");
            Console.WriteLine("If you answer correctly, you will be given the opportunity to deal 3 new cards, or return to the main menu..");
            Console.WriteLine("To begin, select '1' from the main menu to deal 3 cards, or select 2 to quit the application.");
            Console.WriteLine("Good luck!");
            Console.WriteLine();
        }
    }
}
