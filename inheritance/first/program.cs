using System;

namespace class_coupling
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 150;
            text.Copy();
            Console.WriteLine("Hello World!");
        }
    }
}
