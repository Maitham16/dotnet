using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTutorial
{
     class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var divisibleByThree = from num in numbers
                                   where num % 3 == 0
                                   select num;

            foreach (var number in divisibleByThree)
            {
                Console.WriteLine(number);
            }
        }
    }

}
