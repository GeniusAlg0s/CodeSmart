using System;

namespace sectree
{
    class Child
    {
        Node node;
        Child next = null;

        public Child(Node node)
        {
            this.node = node;
        }
        public void addChild(Node node)
        {
            if (this.next == null)
                this.next = new Child(node);
            else
                this.next.addChild(node);
        }
    }
    class Node
    {
        public string data;
        public Child children = null;

        public Node (string data)
        {
            this.data = data;
        }
        public void addChild(Node node)
        {
            if (this.children == null)
                this.children = new Child(node);
            else
                this.children.addChild(node);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node("people");
            first.addChild(new Node("healthflow"));


            
        }
    }
}
