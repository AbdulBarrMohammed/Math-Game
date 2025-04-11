using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame
{
    public class HistoryController
    {
        public void AddHistory(GameItem gameItem)
        {
            // Adds new game item to mockdatabase
            MockDatabase.games.Add(gameItem);
        }

        public void ViewHistory()
        {
            // loop trough mockdatabase
            foreach(var game in MockDatabase.games)
            {
                Console.WriteLine($"{game.Date} - {game.OperationName} - {game.Score}");
                System.Console.WriteLine("Press Any Key to Continue.");
                Console.ReadKey();
            }
        }
    }
}
