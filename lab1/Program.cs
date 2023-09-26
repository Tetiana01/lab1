using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DequeClass<string> usersDeck = new DequeClass<string>();
            usersDeck.AddFirst("Alice");
            usersDeck.AddLast("Kate");
            usersDeck.AddLast("Tom");

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            string removedItem = usersDeck.RemoveFirst();
            Console.WriteLine("\nDeleted: {0} \n", removedItem);

            foreach (string s in usersDeck)
                Console.WriteLine(s);
        }
    }
}
