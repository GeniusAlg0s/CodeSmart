using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Hello World!");

            int number;
             number = 3;

             const float pi = 3.14f;
              float totalPrice = 20.95f;
            string me = "pat";
            byte lumber = 2;
               Console.WriteLine(lumber + " :byte" + number + " :number" + pi + " :float");
              Console.WriteLine(me + " :string"  + " :number" + pi + " :float");
             Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            byte b = 1;
              int i = b;

            int j = 2;
            byte c = (byte)j;
            int w = 1000;
            byte q = (byte)w;

            string newest = "1234";
              int i = Convert.ToInt32(newest);
              Console.WriteLine(i);
            
             try
             {
                 string start = "1234";
                 byte q = Convert.ToByte(newest);
                 Console.WriteLine(q);
             }
             catch (Exception)
             {
                  Console.WriteLine("could not convert to byte");
              }
              try
              {
                  string str = "true";
                 bool z = Convert.ToBoolean(str);
                Console.WriteLine(z);
              }
               catch (Exception)
              {
                  Console.WriteLine("could not convert to byte");
               }

            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a + b * c);
            Console.WriteLine(a == c);
            Console.WriteLine(a != c);
            Console.WriteLine(!(a != c));
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b || c > a);


        }

    }
}
