using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class ListItem<T>
    {
        public T Key { get; set; }
        public ListItem<T> Next { get; set; }
    }
}
