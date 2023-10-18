using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace lab1
{
    public class DequeClass<T> : IEnumerable<T>
    {
            DequeElement<T> head;
            DequeElement<T> tail;
            int count;

            public event EventHandler<ItemAddedEventArgs<T>> ItemAdded;
            public event EventHandler<ItemRemovedEventArgs<T>> ItemRemoved;

           // Adding the element
           // Change the link to the head variable
           public void AddLast(T data)
           {
               DequeElement<T> node = new DequeElement<T>(data);

               if (head == null)
                   head = node;
               else
               {
                   tail.Next = node;
                   node.Previous = tail;
               }
               tail = node;
               count++;

               OnItemAdded(new ItemAddedEventArgs<T>(data));
           }

           // Change the link to the tail variable
           public void AddFirst(T data)
           {
               DequeElement<T> node = new DequeElement<T>(data);
               DequeElement<T> temp = head;
               node.Next = temp;
               head = node;
               if (count == 0)
                   tail = head;
               else
                   temp.Previous = node;
               count++;

               OnItemAdded(new ItemAddedEventArgs<T>(data));
           }

            private void OnItemAdded(ItemAddedEventArgs<T> e)
            {
                ItemAdded?.Invoke(this, e);
            }

            // Removing the element
            // Change the link to the first element
           public T RemoveFirst()
           {
               if (count == 0)
                   throw new InvalidOperationException();
               T output = head.Data;
               if (count == 1)
               {
                   head = tail = null;
               }
               else
               {
                   head = head.Next;
                   head.Previous = null;
               }
               OnItemRemoved(new ItemRemovedEventArgs<T>(output));
               count--;
               return output;
           }

           // Change the link to the previous element
           public T RemoveLast()
           {
               if (count == 0)
                   throw new InvalidOperationException();
               T output = tail.Data;
               if (count == 1)
               {
                   head = tail = null;
               }
               else
               {
                   tail = tail.Previous;
                   tail.Next = null;
               }
               OnItemRemoved(new ItemRemovedEventArgs<T>(output));
               count--;
               return output;
           }

           private void OnItemRemoved(ItemRemovedEventArgs<T> e)
           {
               ItemRemoved?.Invoke(this, e);
           }

           public int Count { get { return count; } }
           public bool IsEmpty { get { return count == 0; } }

           public T First
           {
               get
               {
                   if (IsEmpty)
                       throw new InvalidOperationException();
                   return head.Data;
               }
           }

           public T Last
           {
               get
               {
                   if (IsEmpty)
                       throw new InvalidOperationException();
                   return tail.Data;
               }
           }

           public void Clear()
           {
               head = null;
               tail = null;
               count = 0;
           }

           public bool Contains(T data)
           {
               DequeElement<T> current = head;
               while (current != null)
               {
                   if (current.Data.Equals(data))
                       return true;
                   current = current.Next;
               }
               return false;
           }

           IEnumerator IEnumerable.GetEnumerator() // return object
           {
               return ((IEnumerable)this).GetEnumerator();
           }

           IEnumerator<T> IEnumerable<T>.GetEnumerator() //return iterrator
           {
               DequeElement<T> current = head;
               while (current != null)
               {
                   yield return current.Data;
                   current = current.Next;
               }
           }

    }
}


















/*private DequeElement<T> head;
        private DequeElement<T> tail;

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public DequeClass()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void AddLast(T data)
        {
            DequeElement<T> node = new DequeElement<T>(data);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }

            Count++;
        }

        public void AddFirst(T data)
        {
            DequeElement<T> node = new DequeElement<T>(data);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.Next = head;
                head.Previous = node;
                head = node;
            }

            Count++;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            DequeElement<T> current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public bool RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
            }

            RemoveNode(head);
            return true;
        }

        public bool RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
            }

            RemoveNode(tail);
            return true;
        }

        private void RemoveNode(DequeElement<T> node)
        {
            if (node == null)
            {
                return;
            }

            if (node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }
            else
            {
                head = node.Next;
            }

            if (node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }
            else
            {
                tail = node.Previous;
            }

            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            DequeElement<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }*/
