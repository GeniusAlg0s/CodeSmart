using System;
using System.Collections.Generic;
using System.Text;

namespace construct_and_inherit
{
    public class Vehicle
    {
        public readonly string _registrationNumer;
     /*   public Vehicle()
            {
            Console.WriteLine("cehicle initialized");
            }*/
        public Vehicle(string registrationNumer)
        {
            _registrationNumer = registrationNumer;
            Console.WriteLine("car beng initilized. registration is {0}", registrationNumer);
            //Console.WriteLine("cehicle initialized");
        }
    }

   

        
}
