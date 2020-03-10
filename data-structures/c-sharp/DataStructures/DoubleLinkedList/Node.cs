using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleLinkedList
{
    class Node<T>
    {
        public Node<T> Previous { get; set; }
        public T Key { get; set; }
        public Node<T> Next { get; set; }
    }
}
