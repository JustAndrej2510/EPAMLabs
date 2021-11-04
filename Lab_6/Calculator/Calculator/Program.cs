using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b;
                char command;
                Console.Write("Enter first number: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Choose command (+, -, *, /): ");
                command = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Enter second number: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                switch (command)
                {
                    case '+':
                        Console.WriteLine("Result: " + CalculatorCommands.Sum(a, b));
                        break;
                    case '-':
                        Console.WriteLine("Result: " + CalculatorCommands.Substract(a, b));
                        break;
                    case '*':
                        Console.WriteLine("Result: " + CalculatorCommands.Multiply(a, b));
                        break;
                    case '/':
                        Console.WriteLine("Result: " + CalculatorCommands.Divide(a, b));
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        
        }
    }
}
