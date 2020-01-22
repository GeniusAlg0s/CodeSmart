using System;

namespace arrayfun
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            Console.WriteLine("length: " + numbers.Length);
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 : " + index);

            Array.Clear(numbers, 0, 1); //range of elements
            foreach (var n in numbers)
                Console.WriteLine(n);

            var test = new int[3];
            Array.Copy(numbers, test, 3);

            Console.WriteLine("copy");
            foreach (var n in test)
                Console.WriteLine( n);
            Console.WriteLine("\n");

            Array.Sort(numbers);
            Array.Clear(numbers, 0, 1); //range of elements
            foreach (var n in numbers)
                Console.WriteLine(  n);
            Console.WriteLine("\n");

            Array.Reverse(numbers);
           
            foreach (var n in numbers)
                Console.WriteLine(n);
            Console.WriteLine("\n");
        }
    }
}
