using System;

namespace lab1
{
    public class ItemRemovedEventArgs<T> : EventArgs
    {
        public T RemovedItem { get; }

        public ItemRemovedEventArgs(T item)
        {
            RemovedItem = item;
        }
    }
}