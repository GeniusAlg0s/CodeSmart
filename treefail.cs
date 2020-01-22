using System;
using System.IO;

namespace tree
{
    class Program
    {



        class Node
        {
            public int value;
            public Node left;
            public Node right;


            public Node(int firstvalue)
            {
                value = firstvalue;
                left = null;
                right = null;
            }
        }
        class tree
        {
            Node top;

            public tree()
            {
                top = null;
            }
            public tree(int firstvaue)
            {
                top = new Node(firstvaue);
            }

            public void add(int value)
            {
                if (top == null)
                {
                    Node newnode = new Node(value);
                    top = newnode;
                    return;
                }

                Node currentnode = top;
                bool added = false;

                do
                {
                    if (value < currentnode.value)
                    {
                        if (currentnode.left == null)
                        {
                            Node newnode = new Node(value);
                            currentnode.left = newnode;
                            added = true;
                        }
                        else
                        {
                            currentnode = currentnode.left;
                        }
                    }
                    if (value >= currentnode.value)
                    {
                        if (currentnode.right == null)
                        {
                            Node newnode = new Node(value);
                            currentnode.right = newnode;
                            added = true;
                        }
                        else
                        {
                            currentnode = currentnode.left;
                        }
                    }
                }
                while (!added);

            }
            public void addrc(int value)
            {
                addr(ref top, value);
            }
            private void addr(ref Node n, int value)
            {
                if (n == null)
                {
                    Node newNode = new Node(value);
                    n = newNode;
                    return;
                }
                if (value < n.value)
                {
                    addr(ref n.left, value);
                    return;
                }
                if (value >= n.value)
                {
                    addr(ref n.right, value);
                    return;
                }
            }
            /*public void print(Node n, ref string s)
            {
                if(n == null)
                {
                    n = top;
                }
                if(n.left != null)
                {
                    print(n.left, ref s);
                    s = s + n.value.ToString().PadLeft(3);
                }
                else
                {
                    s = s + n.value.ToString().PadLeft(3);
                }
                if(n.right != null)
                {
                    print(n.right, ref s);
                }
            } */
            public virtual void preOrder(Node node)
            {
                if (node == null)
                {
                    return;
                }

                preOrder(node.left);
                Console.Write(node.value + " ");
                preOrder(node.right);
            }
            public virtual Node ArraytoTree(int[] arr, int start, int end)
            {


                if (start > end)
                {
                    return null;
                }


                int mid = (start + end) / 2;
                Node node = new Node(arr[mid]);


                node.left = ArraytoTree(arr, start, mid - 1);


                node.right = ArraytoTree(arr, mid + 1, end);

                return node;
            }

        }
        public static void Main(string[] args)
        {
            var array = new int[5] { 3, 1, 5, 2, 4 };
            tree ftree = new tree();
            //   for(int i =1; i < 5; i++)
            //  {
            ftree.addrc(array[i]);
            //   }
            //  string llistelements = "";
            //  ftree.print(null, ref llistelements);
            top = ftree.ArraytoTree(array, 0, 5);
            ftree.preOr der(array[0]);
        }
    }
}
