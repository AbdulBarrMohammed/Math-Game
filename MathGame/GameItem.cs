using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame
{
    public class GameItem
    {
        public string OperationName { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }

        public GameItem(string operationName, DateTime date, int score)
        {
            OperationName = operationName;
            Date = date;
            Score = score;
        }
    }
}
