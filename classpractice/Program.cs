using System;
using classes.Math;

namespace classes
{
    public enum ShippingMethod
    {
        Regularmail = 1,
        registmail = 2,
        express = 3
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            /*  Person pat = new Person();
              pat.FirstName = "pat";
              pat.LastName = "will";
              pat.Introduce();

              Calculator calculator = new Calculator();
              var result = calculator.Add(1, 2);
              Console.WriteLine(result);

              var grades = new int[3];
              grades[0] = 1;
              var flags = new bool[3];
              flags[0] = true;

              Console.WriteLine(grades[0]);
              Console.WriteLine(grades[1]);
              Console.WriteLine(grades[2]);
                   Console.WriteLine(flags[0]);
              Console.WriteLine(flags[1]);
              Console.WriteLine(flags[2]);

              string firstName = "mike";
              string lastName = "duffy";


              string name = string.Format("My name is {0} {1}", firstName, lastName);
              Console.WriteLine(name);

              var list = new string[3] { "rack", "shaq", "benny" };
              var formattedNames = string.Join(",", list);
              Console.WriteLine(formattedNames);


              var par = "This has been a  very long day of just doing C#\n check path \nc:\\folder\\folder2\n";
              var partwo = @"This has been a  very long day of just doing C#
                           check path 
                          c:\\folder\\folder2";
              Console.WriteLine(par +" " + partwo); */

            var method = ShippingMethod.express;

            Console.WriteLine((int)method);

            var id = 3;
            Console.WriteLine((ShippingMethod)id);
            Console.WriteLine(method.ToString());

            var mname = "express";

           var smethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), mname);

            var a = 10;
            var b = a;
            b++;
          //  Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var temp = array1; 
            var array2 = temp;
            array2[0] = 0;
             
            int i = 0;

            for(i=0; i < 3; i++)
            {
                Console.WriteLine(array1[i]);
                Console.WriteLine(array2[i]);
            }
          //  Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1, array2));
        }
    }
}
