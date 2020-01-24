using System;

namespace interface_etensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DbMigrator(new ConsoleLogger());
            dbmigrator.Migrate();
            Console.WriteLine("Hello World!");
        }
    }
}
