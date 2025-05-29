using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class TicketPriceCalculator
    {
        // Constants for ticket prices
        const int freeEnter = 0;
        const int youthPrice = 80;
        const int seniorPrice = 90;
        const int standardPrice = 120;

       
        public static  void SingleTicket()
        {
            ConsoleUI.Print("Welcome to the Ticket Price Calculator!");
            CheckAgeCategory(); // Call the method to check age category and calculate ticket price
        }
        public static void CheckAgeCategory() 
        {

            ConsoleUI.Print($"Please enter your age:");
            string input = ConsoleUI.GetInput();


            if (int.TryParse(input, out int age)) // Attempt to parse the input as an integer
            {
             
             if( age < 5 || age > 100) 
                {
                    ConsoleUI.Print($"Free enter for Childen lest than 5 year and over 100 year.");
                } else if (age < 20)
                {
                    ConsoleUI.Print($"You are a youth, your ticket price is: {youthPrice} SEK.");
                }
                else if (age > 64)
                {
                    ConsoleUI.Print($"You are a senior, your ticket price is: {seniorPrice} SEK.");
                }
                else if (age >= 20 && age <= 64)
                {
                    ConsoleUI.Print($"You are an adult, your ticket price is: {standardPrice} SEK.");
                }
                else
                {
                    int ticketPrice = GetTicketPrice(age); // Call the method to get the ticket price based on age
                    ConsoleUI.Print($"Your ticket price is: {ticketPrice} SEK.");
                }


            }
            else // If parsing fails, the input is not a valid integer
            {
                ConsoleUI.Print("Invalid input. Please enter a valid age.");
            }
        }

       public static void GroupTicket()
        {

            ConsoleUI.Print("Please enter the number of people in the group:");
            string input = ConsoleUI.GetInput();

            CalcGroupTicket(input);


        }

        private static void CalcGroupTicket(string inputValue)

        {
            if (int.TryParse(inputValue, out int groupSize))
            {
                if (groupSize < 2) // check if the group size is less than 2
                {
                    ConsoleUI.Print("Group size must be at least 2 people.");
                    return;
                }

                List<int> ages = new List<int>();
                int totalPrice = 0;

                for (int i = 0; i < groupSize; i++)
                {
                    ConsoleUI.Print($"Please enter the age of person {i + 1}.");
                    string ageInput = ConsoleUI.GetInput();

                    if (int.TryParse(ageInput, out int age) && age >= 0)
                    {
                        ages.Add(age);
                        totalPrice += GetTicketPrice(age); // Get the ticket price for the current age
                       
                    }

                }
                ConsoleUI.Print($"Total group of {ages.Count} people.");
                ConsoleUI.Print($"Total price: {totalPrice}SEK.");
                ConsoleUI.Print(" ------------------------" );
            }
        }
            
        public static int GetTicketPrice(int age) {
           
            if (age < 5 || age > 100)
            {
                return freeEnter; // Free for children under 5 and seniors over 100
            }
            else if (age < 20)
            {
                return youthPrice; // Youth price
            }
            else if (age > 64)
            {
                return seniorPrice; // Senior price
            }
            else
            {
                return standardPrice; // Standard price
            }
        }
    }
}
