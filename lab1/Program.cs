using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DequeClass<int> numbers = new DequeClass<int>();

            numbers.ItemAdded += (sender, e) =>
            {
                Console.WriteLine($"Element {e.AddedItem} is added to the deque \n");
            };

            numbers.ItemRemoved += (sender, e) =>
            {
                Console.WriteLine($"Element {e.RemovedItem} is removed from the deque \n");
            };

            numbers.AddFirst(2);
            numbers.AddLast(3);
            numbers.AddLast(4);
            numbers.AddFirst(1);
            numbers.AddLast(5);

            foreach (int s in numbers)
                Console.WriteLine(s);

            Console.WriteLine("\nThe count of Deque: {0} \n", numbers.Count);

            int removedItem1 = numbers.RemoveFirst();

            int removedItem2 = numbers.RemoveLast();

            Console.WriteLine("\nShow the new first element: {0} \n", numbers.First);

            Console.WriteLine("\nShow the new last element: {0} \n", numbers.Last);
            
            Console.WriteLine("\nThe count of Deque: {0} \n", numbers.Count);

            foreach (int s in numbers)
                Console.WriteLine(s);

            numbers.Clear();

            Console.WriteLine("\nNew Deque: \n");

            numbers.AddFirst(6);
            numbers.AddFirst(6);
            numbers.AddLast(7);

            bool isIn = numbers.Contains(6);
            Console.WriteLine("\nDeque has 6: {0} \n", isIn);

            foreach (int s in numbers)
                Console.WriteLine(s);

        }
    }
}


