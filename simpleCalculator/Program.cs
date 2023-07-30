using System;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator in C#");

            Console.WriteLine("Enter a number: ");
            string num1 = Console.ReadLine();
            double number1 = Convert.ToDouble(num1);

            Console.WriteLine("Enter another number: ");
            string num2 = Console.ReadLine();
            double number2 = Convert.ToDouble(num2);

            double result = number1 + number2;

            Console.WriteLine($"The result is of adding {number1} and {number2}: " + result);
        }
    }
}
