using System;
using System.Collections.Generic;
using System.Text;

namespace construct_and_inherit
{
    public class Car : Vehicle
    {
        public Car(string registrationNumer)
            : base("registrationNumer")
        {
            Console.WriteLine("car beng initilized. registration is {0}", registrationNumer);
        }
    }
}
