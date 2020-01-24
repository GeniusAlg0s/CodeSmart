using System;

namespace abstractclasses
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw rectangle");

        }
        
    }
    class Program
     {
    static void Main(string[] args)
    {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
    }

    }
}
