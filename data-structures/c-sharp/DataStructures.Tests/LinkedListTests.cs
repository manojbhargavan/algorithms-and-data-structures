using System;
using DataStructures;
using Xunit;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void Test1()
        {
            var list = new LinkedList<int>();
            list.AddLast(10);
            list.AddFirst(20);
            list.AddFirst(30);
            list.AddLast(5);
            list.Insert(20, 12);
            list.Insert(20, 25, false);
            list.Insert(105, 105);
            list.Insert(30, 40, false);
            list.Contains(105);
            list.Contains(30);
            list.Contains(40);
            list.Contains(400);
            list.Insert(20, 12);
            list.Insert(12, 400);
            list = list.Reverse();
            list.Delete(400);
            list.Delete(5);
            list.Delete(105);
            list.Delete(30);
            list.Delete(12);
            list.Insert(20, 12);
            list.Insert(20, 12);
            list.Insert(20, 12);
            list.DeleteAll(12);
        }
    }
}
