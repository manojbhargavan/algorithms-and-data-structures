using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSort.Tests
{
    public static class Extensions
    {
        public static bool EqualityTest<T>(this IEnumerable<T> input, IEnumerable<T> compareTo) where T : IComparable
        {
            if (input.Count() != compareTo.Count())
            {
                return false;
            }

            var inArray = input.ToArray();
            var compareArray = compareTo.ToArray();
            var equal = true;
            for (int i = 0; i < inArray.Length; i++)
            {
                if (inArray[i].CompareTo(compareArray[i]) > 0)
                {
                    equal = false;
                    break;
                }
            }

            return equal;
        }

        public static void Print<T>(this IEnumerable<T> value)
        {
            foreach (var item in value)
            {
                Console.WriteLine(item);
            }
        }
    }
}