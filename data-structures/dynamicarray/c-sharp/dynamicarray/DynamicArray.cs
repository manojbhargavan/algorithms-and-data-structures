using System;
using System.Text;

namespace dynamicarray
{
    public class DynamicArray<T>
    {

        private T[] userArray { get; set; }
        public int Length { get; private set; }
        private int Capacity { get; set; }

        public DynamicArray()
        {
            userArray = new T[16];
            Length = 0;
            Capacity = 16;
        }

        public int Size() { return Length; }

        public bool IsEmpty() { return Length == 0; }

        public T Get(int index)
        {
            if (Length <= index || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return userArray[index];
        }

        public void Set(int index, T value)
        {
            if (Length <= index || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            userArray[index] = value;
        }

        public void Clear()
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = default(T);
            }
        }

        public void Add(T elem)
        {
            if (Length + 1 >= Capacity)
            {
                if (Capacity == 0) Capacity = 1;
                else Capacity *= 2;
                var newArray = new T[Capacity];
                for (int i = 0; i < Length; i++)
                {
                    newArray[i] = userArray[i];
                }
                userArray = newArray;
            }
            userArray[Length++] = elem;
        }

        public T RemoveAt(int rm_index)
        {
            if (rm_index >= 0 && rm_index < Length)
            {
                var returnValue = userArray[rm_index];
                for (int i = rm_index; i < Length - 1; i++)
                {
                    userArray[i] = userArray[i + 1];
                }
                userArray[Length] = default(T);
                Length--;
                return returnValue;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public bool Remove(T obj)
        {
            int index = IndexOf(obj);
            if (index != -1)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public int IndexOf(T obj)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (userArray[i].Equals(obj))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public bool Contains(T obj)
        {
            return IndexOf(obj) != -1;
        }

        public override String ToString()
        {
            if (Length == 0) return "[]";

            StringBuilder str = new StringBuilder("[");
            for (int i = 0; i < Length - 1; i++)
            {
                str.Append(userArray[i].ToString() + ",");
            }
            str.Append(userArray[Length - 1].ToString() + "]");
            return str.ToString();
        }

    }
}