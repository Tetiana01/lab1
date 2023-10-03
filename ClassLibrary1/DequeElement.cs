using System;

namespace ClassLibrary1
{
    public class DequeElement<T>
    {
        public DequeElement(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DequeElement<T> Previous { get; set; }
        public DequeElement<T> Next { get; set; }
    }
}
