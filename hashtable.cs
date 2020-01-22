using System;
using System.Collections;


namespace queueandstack
{
    class Program
    {
        static void Main(string[] args)
        {  Hashtable pat = new Hashtable()
            {
                {1, "udemy course" },
                { 2, "linked list"}
           };
            pat.Add(3, "trees");
            pat.Add(4, "queue");
            pat.Add(5, "stack");

            Console.WriteLine("before");
            print2(pat);
            
            pat.Remove("2");
            Console.WriteLine("after");
            print2(pat);
        }
          public static void print2(IEnumerable collection)
            {
                foreach (DictionaryEntry item in collection)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
        }
    }
}
