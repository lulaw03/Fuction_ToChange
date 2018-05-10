using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuction510
{
    class Program
    {    static void PrintText(string text, ConsoleColor textColor, ConsoleColor bgColor)
        {
            Console.BackgroundColor = textColor;
            Console.ForegroundColor = bgColor;
            Console.WriteLine(text);

        } 
        static void Main(string[] args)
        {
            PrintText("世",ConsoleColor.Red, ConsoleColor.Blue);
            PrintText("新", ConsoleColor.Yellow, ConsoleColor.Red);
            PrintText("好", ConsoleColor.Yellow, ConsoleColor.Red);
            PrintText("廢", ConsoleColor.Yellow, ConsoleColor.Red);
            PrintText("呵呵", ConsoleColor.Yellow, ConsoleColor.Red);

            double n1 = 180;
            double n2 = 50;
            double answer = countBmi(n1, n2);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
        static double countBmi (double a, double b)
        {
            double c = b / ((a/100)* (a / 100));
            return c;
        }
                 
    }
    
}
