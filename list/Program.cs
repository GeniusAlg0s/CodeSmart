using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
    class Program
    {
        
            static void Main(string[] args)
        {

            mlist list = new mlist();
            list.addnode(3);
            list.addnode(3);
            list.addnode(3);
            list.addnode(3);
            Console.WriteLine();
            list.insertbeginnig(3);
            list.insertbeginnig(6);
            list.insertbeginnig(9);
            list.insertbeginnig(12);
            Console.WriteLine();
            list.insertsorted(3);
            list.insertsorted(6);
            list.insertsorted(9);
            list.insertsorted(12);

            list.print();
            // Node fnode = new Node(11);
            /*  fnode.next = new Node(1);
              fnode.next.next = new Node(15);
              fnode.next.next.next = new Node(12); 

            fnode.addnode(5);
            fnode.addnode(12);
            fnode.addnode(13); 

            fnode.print(); */
            /*
              LinkedList<string> tests = new LinkedList<string>();
              tests.AddLast("hello");
              tests.AddFirst("Hey");

              var enterpoint = tests.Find("Hey");
              tests.AddAfter(enterpoint, "guten tag");

              foreach (string test in tests)
              {
                  Console.WriteLine(tests);
              } 

            LinkedList<string> months = new LinkedList<string>();
            months.AddLast("March");
            months.AddFirst("January");

            var march = months.Find("March");

            months.AddBefore(march, "February");
            months.AddAfter(march, "April");

            foreach (string month in months)
            {
                Console.WriteLine(month);
            }

            LinkedList<string> days = new LinkedList<string>();

            days.AddFirst("Monday");
            days.AddLast("Saturday");

            foreach (string day in days)
            {
                Console.WriteLine(day);
            }
            */
        }
    }
}
