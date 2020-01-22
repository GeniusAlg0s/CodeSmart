using System;
using System.Collections.Generic;
using System.Text;

namespace linked
{
    class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
       
    }
    class llist
    {
        public Node headOrStart;

        public void isnertofront(llist a, int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = a.headOrStart;
            a.headOrStart = newNode;
        }

        public void print()
        {
            Console.Write("|" + headOrStart + "|");
            if (headOrStart != null)
            {
               Console.WriteLine( headOrStart.next);
            }
        }


    }
    
        
    
}
