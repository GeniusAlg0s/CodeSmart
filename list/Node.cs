using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
  public  class Node
    {
        
        
            public int data; //actual data stored in the node
            public Node next;// pointer in next node
            public Node(int d)
            {
            //initializing the data and pointer 
                data = d;
                next = null;
            }
        public void print()
        {
            Console.Write("|" + data + "|");
            if (next != null)
            {
                next.print();
            }
        }
        public void insertsorted(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.insertsorted(data);
            }
        }
        public void addnode(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.addnode(data);
            }
        }
    }

    public class mlist
    {
        public Node headnode;

        public mlist()
        {
            headnode = null;
        }
        /* public void addtoend(int data)
         {
             if(headnode == null)
             {
                 headnode = new Node(data);
             }
             else
             {
                 headnode.addtoend(data);
             }
         }*/
        public void addnode(int data)
        {
            if (headnode == null)
            {
                headnode = new Node(data);
            }
            else
            {
                headnode.addnode(data);
            }
        }
        public void insertsorted(int data)
        {
            if (headnode == null)
            {
                headnode = new Node(data);
            }
            else if (data < headnode.data)
            {
                insertbeginnig(data);
            }
            else
            {
                headnode.insertsorted(data);
            }
        }
        public void insertbeginnig(int data)
        {
            if (headnode == null)
            {
                headnode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headnode;
                headnode = temp;
            }
        }
        public void print()
        {
            if(headnode != null)
            {
                headnode.print();
            }
        }
    }
}
