using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
             var random = new Random();
            const int passlength = 10;
            var buffer = new char[passlength];

            for (var i = 0; i < passlength; i++)
                // Console.Write((char)('a' + random.Next(0, 26))); 
                buffer[i] = (char)('a' + random.Next(0, 26));

            var pass = new string(buffer);
            Console.WriteLine("\n"+(int)'a');
            Console.WriteLine("\n" + pass);

        }
    }
}
