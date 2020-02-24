using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 5, 3, 6, 9, 10, 45, 23, 12, 4, 2 };

            var output = InsertionSort.Sort(input);

            foreach (var item in output)
            {
                Console.Write($"{item} ");
            }
        }
    }
}