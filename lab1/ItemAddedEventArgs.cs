using System;

namespace lab1
{
    public class ItemAddedEventArgs<T> : EventArgs
    {
        public T AddedItem { get; }

        public ItemAddedEventArgs(T item)
        {
            AddedItem = item;
        }
    }
}