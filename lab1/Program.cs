using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DequeClass<int> numbers = new DequeClass<int>();
            numbers.AddFirst(2);
            numbers.AddLast(3);
            numbers.AddLast(4);
            numbers.AddFirst(1);
            numbers.AddLast(5);

            foreach (int s in numbers)
                Console.WriteLine(s);

            int removedItem1 = numbers.RemoveFirst();
            Console.WriteLine("\nDelete the first: {0} \n", removedItem1);

            int removedItem2 = numbers.RemoveLast();
            Console.WriteLine("\nDelete the last: {0} \n", removedItem2);

            foreach (int s in numbers)
                Console.WriteLine(s);
        }
    }
}
