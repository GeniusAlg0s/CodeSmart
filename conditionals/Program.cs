using System;

namespace conditionals
{

    class Program
    {
        static void Main(string[] args)
        {
              int hour = 10;

              if (hour > 0 && hour < 12)
                  Console.WriteLine("morning time");
              else if(hour >= 12 && hour < 18)
                  Console.WriteLine("afternoon");
              else
                  Console.WriteLine("night time");

      
             bool goldcust = true;

             float price;

             if (goldcust)
                 price = 19.95f;
             else
                 price = 29.95f;
                 
             float nprice = (goldcust) ? 19.95f : 29.95f;

             Console.WriteLine(price);

             var season = Seasons.Fall;

            switch (season)
            {
                case Seasons.Fall:
                    Console.WriteLine("its fall");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("its Summer");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("its Snow time");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("its flower time");
                    break;
            }
                while(true)
                {
                    Console.Write("input name: ");
                    var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))

            { 
                Console.WriteLine("@Echo: " + input);
                continue;
            }
            break;
        

        }
            var random = new Random();
            for (var i = 0; i > 10; i++)
                Console.WriteLine(random.Next());
        }

    }

}

