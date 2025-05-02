using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Hello World!");
            PrintNumbers("Numbers", numbers);
            PrintNumbers("Even No: ", numbers.Where(x=>IsEven(x)));
            PrintNumbers("Odd No: ", numbers.Where(x => IsOdd(x)));

        }

        public static void PrintNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach (var n in numbers)
            {
                Console.Write($"{n}  ");
            }
            Console.WriteLine($"]");
            Console.WriteLine();
        }
        public static bool IsEven(int number) => number % 2 == 0;

        public static bool IsOdd(int number) => !IsEven(number);
        
        }
    }

        
