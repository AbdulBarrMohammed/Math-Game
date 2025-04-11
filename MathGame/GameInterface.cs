using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame
{
    public class GameInterface
    {
        private readonly HistoryController _historyController = new();
        public void MainMenu()
        {
            while (true)
            {

                System.Console.WriteLine("What game would you like to play today? Choose from the options below:\n");
                System.Console.WriteLine("V - View Previous Games");
                System.Console.WriteLine("A - Addition");
                System.Console.WriteLine("S - Subtraction");
                System.Console.WriteLine("M - Multiplication");
                System.Console.WriteLine("D - Division");
                System.Console.WriteLine("Q - Quit the program");
                string option = Console.ReadLine();

                System.Console.WriteLine($"{option} was your option");
                // press any key to continue

                if (option == "Q")
                {
                    break;
                }
                Console.ReadKey();
            }

        }

        public void AddToHistory(GameItem gameItem)
        {
            _historyController.AddHistory(gameItem);
        }

        public void PlayGame()
        {
            Random rnd = new Random();
            while (true)
            {
                int randNum1 = rnd.Next(1, 100);
                int randNum2 = rnd.Next(1, 100);

                //display current number and operation
                // get user input
                // continue game until they get it wrong then create new game item object with
                // the current score, time, and operation and then add it to history controller

            }
        }

        public void ViewGameHistory()
        {
            _historyController.ViewHistory();
        }
    }
}
