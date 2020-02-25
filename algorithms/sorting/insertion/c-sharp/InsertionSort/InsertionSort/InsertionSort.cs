using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static IEnumerable<T> Sort<T>(IEnumerable<T> input, bool reversed = false) where T : IComparable
        {
            var arrayInput = input.ToArray();
            for (int j = 1; j < arrayInput.Length; j++)
            {
                var key = arrayInput[j];
                var i = j - 1;
                while (i >= 0 && ((!reversed && arrayInput[i].CompareTo(key) > 0) || (reversed && arrayInput[i].CompareTo(key) < 0)))
                {
                    arrayInput[i + 1] = arrayInput[i];
                    i--;
                }
                arrayInput[i + 1] = key;
            }

            return arrayInput;
        }
    }
}