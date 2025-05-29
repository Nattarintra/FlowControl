using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class RepeatTenTimes
    {
// welcome to my looping world
        public static void RepeatInput()
        {
            ConsoleUI.Print("Welcome to the looping world!");

            ConsoleUI.Print("Please enter your input:");
            string input = ConsoleUI.GetInput();


            // Use a for loop to print it 10 times
            for (int i = 1; i <= 10; i++)
            {
                // Print without line breaks
                Console.Write($"{i}. {input}");

                if (i < 10) // Check if it's not the last iteration to avoid trailing comma
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine(); // Move to next line after loop
            ConsoleUI.Print("Thank you for visiting the loop world!");
        }
    }
}
