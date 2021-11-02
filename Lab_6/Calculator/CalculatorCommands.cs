using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorCommands
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot be divide by zero");
 
            return a / b;
        }
    }
}
