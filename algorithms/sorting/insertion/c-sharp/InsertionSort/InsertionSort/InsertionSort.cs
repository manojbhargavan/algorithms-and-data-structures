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
            for (int i = 1; i < arrayInput.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if ((!reversed && arrayInput[j].CompareTo(arrayInput[j + 1]) > 0) || (reversed && arrayInput[j].CompareTo(arrayInput[j + 1]) < 0))
                    {
                        var key = arrayInput[j + 1];
                        arrayInput[j + 1] = arrayInput[j];
                        arrayInput[j] = key;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return arrayInput;
        }
    }
}