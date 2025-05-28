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
            ConsoleUI.Print("Welcome to my C-sharp App");
            ConsoleUI.Print("1 - Single ticket & price");
            ConsoleUI.Print("2 - Group ticket & price");
            ConsoleUI.Print("3 - Repeat input 10 times");
            ConsoleUI.Print("4 - Extract third word");
            ConsoleUI.Print("0 - Exit the program");
        }

        private static void DoSwitchLoopInput()
        {
            
            bool isExit = false;
            do
            {
                string input = ConsoleUI.GetInput(); 
                switch (input)
                {
                    case MenuHelpers.SigleTicket:
                        //TicketAndPrice();
                        ConsoleUI.Print("This will be Single ticket and price");
                        break;
                    case MenuHelpers.GroupTicket:
                        //CalcGroupTicket();
                        ConsoleUI.Print("Group ticket and price");
                        break;
                    case MenuHelpers.Repeat:

                        //RepeatTenTimes();
                        ConsoleUI.Print("Repeat input 10 times");
                       
                        break;
                    case MenuHelpers.SpritTheWord:
                        //SpritTheWord();
                        ConsoleUI.Print("Split the word");
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
