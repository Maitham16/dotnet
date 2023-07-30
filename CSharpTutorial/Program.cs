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

            // arrays
            int[,,] array1 = new int[2, 2, 2] { 
                { { 1, 2 }, { 3, 4 } }, 
                { { 5, 6 }, { 7, 8 } }
                };

            for (int i=0; i < array1.GetLength(0); i++)
            {
                for (int j=0; j < array1.GetLength(1); j++)
                {
                    for (int k=0; k < array1.GetLength(2); k++)
                    {
                        Console.WriteLine(array1[i, j, k]);
                    }
                }
            }

            int[,] arrayA = new int[,]
            {
                {1, 1, 1},
                {1, 1, 1},
                {1, 1, 1}
            };

            int[,] arrayB = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int[,] arrayC = new int[3, 3];

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    arrayC[i, j] = arrayA[i, j] * arrayB[i, j];
                }
            }

            for (int i = 0; i < arrayC.GetLength(0); i++)
            {
                for (int j = 0; j < arrayC.GetLength(1); j++)
                {
                    Console.Write(arrayC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}

// here we are using the LINQ query syntax to select all numbers in the list that are
// divisible by 3 and then we are printing them out to the console.
