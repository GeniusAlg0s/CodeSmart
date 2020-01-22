using System;
using System.Collections;


namespace queueandstack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue first = new Queue();

            first.Enqueue(3);
            first.Enqueue(6);
            first.Enqueue(9);
            first.Enqueue(12);

            Console.WriteLine();
            Console.WriteLine("queue:");

            Console.WriteLine("before");
            print(first);

            first.Dequeue();
            Console.WriteLine("after");

            print(first);
            Console.WriteLine();
            Console.WriteLine("stack:");

            Stack plates = new Stack();

            plates.Push(2);
            plates.Push(4);
            plates.Push(6);
            plates.Push(8);
            plates.Push(10);
            plates.Push(12);
            Console.WriteLine("before");

            print(plates);

           
            plates.Pop();
            plates.Pop();
            Console.WriteLine("after");

            print(plates);
        }

        public static void print(IEnumerable collection)
        {
            foreach(Object item in collection)
            {
                Console.Write(item + " | ");
            }
        }
    }
}
