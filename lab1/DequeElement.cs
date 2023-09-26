using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class DequeElement<T>
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
