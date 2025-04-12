using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame.obj
{
    public static class Operate
    {
        public static bool Addition(int num1, int num2)
        {
            System.Console.WriteLine($"{num1} + {num2}");
            int correctTotal = num1 + num2;
            string userAnswer = Console.ReadLine();
            if (int.Parse(userAnswer) == correctTotal) return true;
            return false;


        }

        public static bool Subtraction(int num1, int num2)
        {
            System.Console.WriteLine($"{num1} - {num2}");
            int correctTotal = num1 - num2;
            string userAnswer = Console.ReadLine();
            if (int.Parse(userAnswer) == correctTotal) return true;
            return false;
        }

        public static bool Multiplication(int num1, int num2)
        {
            System.Console.WriteLine($"{num1} * {num2}");
            int correctTotal = num1 * num2;
            string userAnswer = Console.ReadLine();
            if (int.Parse(userAnswer) == correctTotal) return true;
            return false;
        }

        public static bool Division(int num1, int num2)
        {
            System.Console.WriteLine($"{num1} / {num2}");
            int correctTotal = num1 / num2;
            string userAnswer = Console.ReadLine();
            if (int.Parse(userAnswer) == correctTotal) return true;
            return false;
        }


    }
}
