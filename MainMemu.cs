using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class MainMemu
    {
       
        public static void ShowMainMenu()
        {
            GreetingMessage();
            DoSwitchLoopInput();
        }

        private static void GreetingMessage()
        {
            ConsoleUI.Print("Welcome to my C-sharp App \n");
            ConsoleUI.Print("1 - Single ticket & price");
            ConsoleUI.Print("2 - Group ticket & price");
            ConsoleUI.Print("3 - Repeat input 10 times");
            ConsoleUI.Print("4 - Extract third word");
            ConsoleUI.Print("0 - Exit the program");
            ConsoleUI.Print("---------------------------");
        }

        private static void DoSwitchLoopInput()
        {
            
            bool isExit = false;
            do
            {
                ConsoleUI.Print("Select number: ");
                string input = ConsoleUI.GetInput(); 
                switch (input)
                {
                    case MenuHelpers.SigleTicket:
                        TicketPriceCalculator.SingleTicket();   
                        break;
                    case MenuHelpers.GroupTicket:
                        TicketPriceCalculator.GroupTicket();   
                        break;
                    case MenuHelpers.Repeat:
                        RepeatTenTimes.RepeatInput();
                        break;
                    case MenuHelpers.ExtractThirdWord:
                        ExtractTheWord.SpritAndGetThirdWord();
                        break;
                    case MenuHelpers.Exit:
                        isExit = true;
                        ConsoleUI.Print("Exit the program");
                        break;
                    default:
                        ConsoleUI.Print("Invalid input, please try again.");
                        break;
                }
            }
            while (!isExit);
        }


    }


}
