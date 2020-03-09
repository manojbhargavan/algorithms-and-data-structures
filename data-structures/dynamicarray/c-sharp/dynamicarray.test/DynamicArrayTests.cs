using System;
using Xunit;

namespace dynamicarray.test
{
    public class DynamicArrayTests
    {
        [Fact]
        public void TestEmptyList()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            // Assert
            Assert.True(list.IsEmpty());
        }

        [Fact]
        public void TestRemovingEmpty()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(0));
        }

        [Fact]
        public void TestIndexOutOfBounds()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            list.Add(10);
            list.Add(15);
            list.Add(20);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(3));
        }

        [Fact]
        public void TestIndexOutOfBounds2()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 1000; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(1000));
        }

        [Fact]
        public void TestIndexOutOfBounds3()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 1000; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(-1));
        }

        [Fact]
        public void TestIndexOutOfBounds4()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 15; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(-66));
        }

        [Fact]
        public void TestIndexOutOfBounds5()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 10; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.Set(10, 3));
        }

        [Fact]
        public void TestIndexOutOfBounds6()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 10; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.Set(15, 3));
        }

        [Fact]
        public void TestIndexOutOfBounds7()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 10; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.Set(-1, 3));
        }

        [Fact]
        public void TestIndexOutOfBounds8()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 10; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.Get(-2));
        }

        [Fact]
        public void TestIndexOutOfBounds9()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 10; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.Get(10));
        }

        [Fact]
        public void TestIndexOutOfBounds10()
        {
            // Arrage & Act
            DynamicArray<Int32> list = new DynamicArray<int>();
            for (int i = 0; i < 10; i++) list.Add(i);
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => list.Get(15));
        }

        [Fact]
        public void TestRemoving()
        {
            DynamicArray<String> list = new DynamicArray<String>();
            String[] sampleStrings = { "a", "b", "c", "d", "e", "i", "g", "h" };
            foreach (String s in sampleStrings) list.Add(s);
            bool ret = list.Remove("c");
            Assert.True(ret);

            ret = list.Remove("c");
            Assert.False(ret);

            ret = list.Remove("h");
            Assert.True(ret);

            ret = list.Remove("i");
            Assert.True(ret);

            ret = list.Remove("a");
            Assert.True(ret);

            ret = list.Remove("a");
            Assert.False(ret);

            ret = list.Remove("h");
            Assert.False(ret);

            ret = list.Remove("i");
            Assert.False(ret);
        }

        [Fact]
        public void TestRemoving2()
        {
            DynamicArray<String> list = new DynamicArray<String>();
            String[] sampleStrings = { "a", "b", "c", "d" };
            foreach (String s in sampleStrings) list.Add(s);
            Assert.True(list.Remove("a"));
            Assert.True(list.Remove("b"));
            Assert.True(list.Remove("c"));
            Assert.True(list.Remove("d"));

            Assert.False(list.Remove("a"));
            Assert.False(list.Remove("b"));
            Assert.False(list.Remove("c"));
            Assert.False(list.Remove("d"));
        }

        [Fact]
        public void TestAddingElements()
        {
            DynamicArray<Int32> list = new DynamicArray<Int32>();

            int[] elems = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < elems.Length; i++) list.Add(elems[i]);

            for (int i = 0; i < elems.Length; i++) Assert.Equal(elems[i], list.Get(i));
        }

        [Fact]
        public void TestAddAndRemove()
        {
            DynamicArray<long> list = new DynamicArray<long>();

            for (int i = 0; i < 55; i++) list.Add(44L);
            for (int i = 0; i < 55; i++) list.Remove(44L);
            Assert.True(list.IsEmpty());

            for (int i = 0; i < 55; i++) list.Add(44L);
            for (int i = 0; i < 55; i++) list.RemoveAt(0);
            Assert.True(list.IsEmpty());

            for (int i = 0; i < 155; i++) list.Add(44L);
            for (int i = 0; i < 155; i++) list.Remove(44L);
            Assert.True(list.IsEmpty());

            for (int i = 0; i < 155; i++) list.Add(44L);
            for (int i = 0; i < 155; i++) list.RemoveAt(0);
            Assert.True(list.IsEmpty());
        }

        [Fact]
        public void TestAddSetRemove()
        {

            DynamicArray<long> list = new DynamicArray<long>();

            for (int i = 0; i < 55; i++) list.Add(44L);
            for (int i = 0; i < 55; i++) list.Set(i, 33L);
            for (int i = 0; i < 55; i++) list.Remove(33L);
            Assert.True(list.IsEmpty());

            for (int i = 0; i < 55; i++) list.Add(44L);
            for (int i = 0; i < 55; i++) list.Set(i, 33L);
            for (int i = 0; i < 55; i++) list.RemoveAt(0);
            Assert.True(list.IsEmpty());

            for (int i = 0; i < 155; i++) list.Add(44L);
            for (int i = 0; i < 155; i++) list.Set(i, 33L);
            for (int i = 0; i < 155; i++) list.Remove(33L);
            Assert.True(list.IsEmpty());

            for (int i = 0; i < 155; i++) list.Add(44L);
            for (int i = 0; i < 155; i++) list.RemoveAt(0);
            Assert.True(list.IsEmpty());
        }

        [Fact]
        public void TestSize()
        {

            DynamicArray<Int32?> list = new DynamicArray<Int32?>();

            Int32?[] elems = { -76, 45, 66, 3, null, 54, 33 };
            for (int i = 0, sz = 1; i < elems.Length; i++, sz++)
            {
                list.Add(elems[i]);
                Assert.Equal(list.Size(), sz);
            }
        }

    }
}