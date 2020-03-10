using DataStructures.DoubleLinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Length { get; private set; }

        public void AddFirst(T item)
        {
            var nodeToAdd = new Node<T>() { Key = item };
            if (Head == null)
            {
                Head = nodeToAdd;
                Tail = nodeToAdd;
            }
            else
            {
                nodeToAdd.Next = Head;
                Head.Previous = nodeToAdd;
                Head = nodeToAdd;
            }
            Length++;
        }

        public void AddLast(T item)
        {
            var nodeToAdd = new Node<T>() { Key = item };
            if (Tail == null)
            {
                AddFirst(item);
            }
            else
            {
                nodeToAdd.Previous = Tail;
                Tail.Next = nodeToAdd;
                Tail = nodeToAdd;
                Length++;
            }
        }

        public void Insert(T key, T itemToInsert, bool after = true)
        {
            var keyItem = GetNode(key);
            if (keyItem != null)
            {
                if (Head == keyItem)
                {
                    AddFirst(itemToInsert);
                }
                else if (Tail == keyItem)
                {
                    AddLast(itemToInsert);
                }
                else
                {
                    var item = new Node<T>() { Key = itemToInsert };
                    if (after)
                    {
                        item.Previous = keyItem;
                        item.Next = keyItem.Next;
                        keyItem.Next.Previous = item;
                        keyItem.Next = item;
                    }
                    else
                    {
                        item.Previous = keyItem.Previous;
                        item.Next = keyItem;
                        keyItem.Previous = item;
                        item.Previous.Next = item;
                    }
                    Length++;
                }
            }
            else
            {
                AddLast(itemToInsert);
            }
        }
        public void Delete(T key)
        {
            if (Contains(key))
            {
                var item = GetNode(key);
                //Item is head
                if (Head == item)
                {
                    Head = item.Next;
                    item = null;
                }
                else if (Tail == item)
                {
                    item.Previous.Next = null;
                    item = null;
                }
                else
                {
                    item.Next.Previous = item.Previous;
                    item.Previous.Next = item.Next;
                    item = null;
                }
                Length--;
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

            var result = GetNode(Key);
            return result != null;
        }

        /// <summary>
        /// Checks if the List is empty
        /// </summary>
        /// <returns>true/false</returns>
        public bool IsEmpty()
        {
            return Head == null;
        }

        private Node<T> GetNode(T searchItem)
        {
            var currentNode = Head;
            do
            {
                if (currentNode.Key.Equals(searchItem))
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            } while (currentNode != null);
            return null;
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
    }
}
