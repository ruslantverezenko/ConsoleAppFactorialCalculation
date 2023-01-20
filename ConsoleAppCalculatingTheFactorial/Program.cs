using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculatingTheFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                CalculatingTheFactorial();
                
                Console.Write("Again?(yes or no): ");
                string userSelection = Console.ReadLine();
                if (userSelection == "no")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            

        }
        static void CalculatingTheFactorial()
        {
            Console.Write("Enter a number to calculate the factorial(without !): ");
            int num = int.Parse(Console.ReadLine());
            int faktorial = 1;
            for (int i = 1; i < num + 1; i++)
            {
                faktorial = faktorial * i;
            }
            Console.WriteLine($"factorial: {faktorial}");
        }
    }
}
