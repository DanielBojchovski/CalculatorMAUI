using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMAUI
{
    public static class Calculation
    {
        public static double Calculate(double num1, double num2, string operatorMath)
        {
            double result = 0;
            switch (operatorMath)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
