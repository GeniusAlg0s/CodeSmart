using System;

namespace methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
        int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("failed");
            //UseCalculator();
            //Usepoints();
        }

        static void UseCalculator()
        {
            var caculate = new calculator();

            Console.WriteLine(caculate.Add(2, 4, 6, 8));
            Console.WriteLine(caculate.Add(new int[] { 10, 4, 6, 8 }));
        }
        static void Usepoints()
        {
            try
            {
                var point = new Point(12, 25);
                point.Move(new Point(40, 60));

                Console.WriteLine("Point is at: ({0} ,{1})", point.X, point.Y);

                point.Move(250, 350);
                point.Move(null);
                Console.WriteLine("Now Point is at: ({0} ,{1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("unexpected error");
            }

        }
    }
        
    
}
