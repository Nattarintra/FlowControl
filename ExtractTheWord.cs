using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class ExtractTheWord
    {
        public static void SpritAndGetThirdWord()
        {
            ConsoleUI.Print("Please enter a sentence:");
            string input = ConsoleUI.GetInput();
            // Split the input into words using space as a delimiter
            string[] words = input.Split(' ');
            // Check if there are at least three words
            if (words.Length >= 3)
            {
                // Get the third word (index 2)
                string thirdWord = words[2];
                ConsoleUI.Print($"The third word is: {thirdWord}");
            }
            else
            {
                ConsoleUI.Print("The input does not contain enough words.");
            }
        }
    }
}
