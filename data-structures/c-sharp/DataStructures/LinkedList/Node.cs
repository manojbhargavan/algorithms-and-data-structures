using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    class Node<T>
    {
        public T Key { get; set; }
        public Node<T> Next { get; set; }
    }
}
