using System;
using System.IO;

namespace up_down_casting
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*  Text text = new Text();
               Shape shape = text;

               text.Width = 200;
               shape.Width = 100;

               Console.WriteLine(text.Width);  */

            Shape shape = new Text();
            Text text = (Text)shape;

            
        }
    }
}
