using System;
using System.Collections.Generic;
using Xunit;

namespace InsertionSort.Tests
{
    public class Tests
    {
        [Theory]
        [InlineData(new int[] { 5, 3, 6, 9, 10, 45, 23, 12, 4, 2 }, new int[] { 2, 3, 4, 5, 6, 9, 10, 12, 23, 45 })]
        [InlineData(new int[] { 20, 2, 10, 6, 52, 31, 0, 45, 79, 40 }, new int[] { 0, 2, 6, 10, 20, 31, 40, 45, 52, 79 })]
        [InlineData(new int[] { 90, -20, 8, 11, 3 }, new int[] { -20, 3, 8, 11, 90 })]
        [InlineData(new int[] { 33, 22, 11, 21, 55, 32, 3, 4 }, new int[] { 3, 4, 11, 21, 22, 32, 33, 55 })]
        [InlineData(new int[] { 11, 22, 33, 44, 55, 66, 77 }, new int[] { 77, 66, 55, 44, 33, 22, 11 }, true)]
        public void InsertionSortTests(IEnumerable<int> input, IEnumerable<int> expectedOutput, bool desc = false)
        {
            // Arrange

            //Act
            var actualOutput = InsertionSort.Sort(input, desc);
            actualOutput.Print();

            //Assert
            Assert.True(expectedOutput.EqualityTest(actualOutput));
        }
    }
}