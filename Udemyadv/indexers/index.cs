using System;

namespace indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new Httpcookie();
            cookie["name"] = "pat";
            Console.WriteLine(cookie["name"]);
        }
    }
}
