using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private ListItem<T> Head { get; set; }
        private ListItem<T> Tail { get; set; }

        /// <summary>
        /// Add to the beginning of this list
        /// </summary>
        /// <param name="item">Item to add</param>
        public void AddFirst(T item)
        {
            var listItem = new ListItem<T>() { Key = item };
            if (Head == null)
            {
                Head = listItem;
                Tail = listItem;
            }
            else
            {
                listItem.Next = Head;
                Head = listItem;
            }
        }

        /// <summary>
        /// Add to the end of this list
        /// </summary>
        /// <param name="item">Item to add</param>
        public void AddLast(T item)
        {
            if (Head == null)
            {
                AddFirst(item);
            }
            else
            {
                var listItem = new ListItem<T>() { Key = item };
                Tail.Next = listItem;
                Tail = listItem;
            }
        }

        /// <summary>
        /// Insert Before or after the key, if key is not found adds to the end of the list
        /// </summary>
        /// <param name="key">Item will be inserted before or after the key</param>
        /// <param name="itemToInsert">Item to insert</param>
        /// <param name="after">
        /// If true inserts after key else before key. By default inserts after the key
        /// If list is empty creates the item as a head of the list
        /// If key is not found adds the item to the end of the list
        /// </param>
        public void Insert(T key, T itemToInsert, bool after = true)
        {
            if (Head == null)
            {
                AddFirst(itemToInsert);
            }
            else
            {
                var searchItem = GetItemAndBefore(key);
                if (searchItem.Item1 == null && searchItem.Item2 == null)
                {
                    AddLast(itemToInsert);
                }
                else
                {
                    if (searchItem.Item1 == null && searchItem.Item2 != null)
                    {
                        after = true;
                    }
                    var insertAfterItem = after ? GetItemAndBefore(key).Item2 : GetItemAndBefore(key).Item1;
                    var listItem = new ListItem<T>() { Key = itemToInsert, Next = insertAfterItem.Next };
                    insertAfterItem.Next = listItem;
                }
            }
        }

        public void Delete(T key)
        {
            if (Contains(key))
            {
                var item = GetItemAndBefore(key);
                //Item is head
                if (item.Item1 == null)
                {
                    Head = item.Item2?.Next;
                    item.Item2 = null;
                }
                else
                {
                    item.Item1.Next = item.Item2?.Next;
                    item.Item2 = null;
                }
            }
        }

        public void DeleteAll(T key)
        {
            while (Contains(key))
            {
                Delete(key);
            }
        }

        /// <summary>
        /// Checks if the key is present in the List
        /// </summary>
        /// <param name="Key">Checks if the items is present in the List</param>
        /// <returns>true/false</returns>
        public bool Contains(T Key)
        {
            if (IsEmpty())
            {
                return false;
            }

            var result = GetItemAndBefore(Key);
            return result.Item2 != null;
        }

        /// <summary>
        /// Checks if the List is empty
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsEmpty()
        {
            return Head == null;
        }

        private (ListItem<T>, ListItem<T>) GetItemAndBefore(T searchItem)
        {
            ListItem<T> prevItem = null;
            var currentListItem = Head;
            do
            {
                if (currentListItem.Key.Equals(searchItem))
                {
                    return (prevItem, currentListItem);
                }
                prevItem = currentListItem;
                currentListItem = currentListItem.Next;
            } while (currentListItem != null);
            return (null, null);
        }

        /// <summary>
        /// Returns a new instance of reversed list
        /// </summary>
        /// <returns>Returns a new instance of reversed list</returns>
        public LinkedList<T> Reverse()
        {
            var newList = new LinkedList<T>();
            foreach (var item in this)
            {
                newList.AddFirst(item);
            }
            return newList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentListItem = Head;
            do
            {
                var returnValue = currentListItem.Key;
                currentListItem = currentListItem.Next;
                yield return returnValue;
            } while (currentListItem != null);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder listString = new StringBuilder("");
            foreach (var item in this)
            {
                listString.Append($"{item} --> ");
            }
            return listString.Append(" NULL").ToString();
        }
    }
}
