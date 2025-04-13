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

                //Validation of user inputs
                if (operation == "Q") break;
                else if (operation == "V") ViewGameHistory();
                else if (operation != "A" && operation != "S" && operation != "M" && operation != "D") Console.WriteLine("Option not available");
                else PlayGame();
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
            bool gameOn = true;
            while (gameOn)
            {
                int randNum1 = rnd.Next(1, 100);
                int randNum2 = rnd.Next(1, 100);

                switch(operation)
                {
                    case "A":
                        if(Operate.Addition(randNum1, randNum2)) currentTotal += 1;
                        else {
                            Console.WriteLine("GAME OVER");
                            _historyController.AddHistory(new GameItem("Addition", DateTime.Now, currentTotal));
                            gameOn = false;
                        }
                        break;
                    case "S":
                        if(Operate.Subtraction(randNum1, randNum2)) currentTotal += 1;
                        else {
                            Console.WriteLine("GAME OVER");
                            _historyController.AddHistory(new GameItem("Subtraction", DateTime.Now, currentTotal));
                            gameOn = false;
                        }
                        break;
                    case "M":
                        if(Operate.Multiplication(randNum1, randNum2)) currentTotal += 1;
                        else {
                            Console.WriteLine("GAME OVER");
                            _historyController.AddHistory(new GameItem("Multiplication", DateTime.Now, currentTotal));
                            gameOn = false;
                        }
                        break;
                    case "D":
                        bool divAns = true;
                        if (randNum1 > randNum2) divAns = Operate.Division(randNum1, randNum2);
                        if (randNum2 > randNum1) divAns = Operate.Division(randNum2, randNum1);
                        if(divAns) currentTotal += 1;
                        else {
                            Console.WriteLine("GAME OVER");
                            _historyController.AddHistory(new GameItem("Division", DateTime.Now, currentTotal));
                            gameOn = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Entered wrong operation");
                        break;
                }

            }
            System.Console.WriteLine("");
            Console.WriteLine($"Your score is: {currentTotal}");
            System.Console.WriteLine("Press any key to go back");
            System.Console.WriteLine("");

        }

        public void ViewGameHistory()
        {
            Console.WriteLine("Your game History:");
            Console.WriteLine("---------------------------------------------");
            _historyController.ViewHistory();

        }
    }
}
