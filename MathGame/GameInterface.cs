using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MathGame.obj;

namespace MathGame
{
    public class GameInterface
    {
        private readonly HistoryController _historyController = new();
        private string operation;
        public void MainMenu()
        {
            while (true)
            {
                // Main menu for users to pick which math operation game they want or if they want to quit
                System.Console.WriteLine("What game would you like to play today? Choose from the options below:\n");
                System.Console.WriteLine("V - View Previous Games");
                System.Console.WriteLine("A - Addition");
                System.Console.WriteLine("S - Subtraction");
                System.Console.WriteLine("M - Multiplication");
                System.Console.WriteLine("D - Division");
                System.Console.WriteLine("Q - Quit the program");
                operation = Console.ReadLine();

                System.Console.WriteLine($"{operation} was your option");
                // press any key to continue

                if (operation == "Q") break;
                else PlayGame();
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
            int currentTotal = 0;
            while (true)
            {
                int randNum1 = rnd.Next(1, 100);
                int randNum2 = rnd.Next(1, 100);

                switch(operation)
                {
                    case "A":
                        if(Operate.Addition(randNum1, randNum2)) currentTotal += 1;
                        else {
                            _historyController.AddHistory(new GameItem(operation, DateTime.Now, currentTotal));
                            break;
                        }
                        break;
                    case "S":
                        if(Operate.Subtraction(randNum1, randNum2)) currentTotal += 1;
                        else {
                            _historyController.AddHistory(new GameItem(operation, DateTime.Now, currentTotal));
                            break;
                        }
                        break;
                    case "M":
                        if(Operate.Multiplication(randNum1, randNum2)) currentTotal += 1;
                        else {
                            _historyController.AddHistory(new GameItem(operation, DateTime.Now, currentTotal));
                            break;
                        }
                        break;
                    case "D":
                        if(Operate.Division(randNum1, randNum2)) currentTotal += 1;
                        else {
                            _historyController.AddHistory(new GameItem(operation, DateTime.Now, currentTotal));
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Entered wrong operation");
                        break;
                }

                // display current numbers and operation
                // get user input
                // continue game until they get it wrong then create new game item object with
                // the current score, time, and operation and then add it to history controller
                Console.WriteLine($"Your current score is: {currentTotal}");
                currentTotal = 0;

            }
        }

        public void ViewGameHistory()
        {
            _historyController.ViewHistory();
        }
    }
}
