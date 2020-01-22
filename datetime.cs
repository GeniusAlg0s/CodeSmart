using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var datetime = new DateTime(2020, 1, 1);
            var today = DateTime.Now;
            var ntoday = DateTime.Today;

           /* Console.WriteLine("Hour: " + today.Hour);
            Console.WriteLine("Minute: " + today.Minute);
            */
            var tommorw = today.AddDays(1);
            var yesterday = today.AddDays(-1);

            Console.WriteLine(today.ToLongDateString());
            Console.WriteLine(today.ToShortDateString());
            Console.WriteLine(today.ToLongTimeString());
            Console.WriteLine(today.ToShortTimeString());
            Console.WriteLine(today.ToString());
            Console.WriteLine(today.ToString("yyyy-MM-dd"));
            Console.WriteLine(today.ToString("yyyy-MM-dd HH:mm"));


            var timespan = new TimeSpan(1, 2, 3);
            var timespan2 = new TimeSpan(1, 0, 0);
            var timespan3 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(5);
            var elasped = end - start;
            Console.WriteLine("duration: " + elasped);

            Console.WriteLine("total minutes: " + timespan.TotalMinutes);
                 Console.WriteLine(" minutes: " + timespan.Minutes);


            Console.WriteLine(" add example: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(" subtract example: " + timespan.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine("To string: " + timespan.ToString());

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
