using System;

namespace classadv
{
    class Program
    {
        class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("this {0}, I am {1}", to, Name);
            }
            /*( static allows for object to be accessed with out new object*/
            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;
                return person;
            }
        }
        static void Main(string[] args)
        {
            var me = new Person();
            var you = new Person();

            // var y = you.Parse("john");
            var he = Person.Parse("mike");
            me.Name = "pat";
            he.Introduce("mike2");
            me.Introduce("Nick");
            
        }
    }
}
