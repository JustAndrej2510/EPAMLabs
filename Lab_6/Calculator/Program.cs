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
                Console.Write("Введите 1 число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите действие (+, -, *, /): ");
                command = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Введите 2 число: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                switch (command)
                {
                    case '+':
                        Console.WriteLine(CalculatorCommands.Sum(a, b));
                        break;
                    case '-':
                        Console.WriteLine(CalculatorCommands.Substract(a, b));
                        break;
                    case '*':
                        Console.WriteLine(CalculatorCommands.Multiply(a, b));
                        break;
                    case '/':
                        Console.WriteLine(CalculatorCommands.Divide(a, b));
                        break;
                    default:
                        Console.WriteLine("Такой операции не существует");
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
