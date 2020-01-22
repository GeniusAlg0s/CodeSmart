using System;

public class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int d)
    {
        data = d;
        left = right = null;
    }
}
    public class BinaryTree
    {
        public static Node root;

        public virtual Node arraytotree(int[] arr, int start, int end)
        {
            if(start > end)
            {
            return null;
            }
        int mid = (start + end) / 2;

        Node node = new Node(arr[mid]);

        node.left = arraytotree(arr, start, mid - 1);
        node.right = arraytotree(arr, start, mid - 1);

        return node;
        }
        public virtual void print(Node node)
        {
        if(node == null)
        {
            return;
        }
        print(node.left);
        Console.Write(node.data + " ");
        print(node.right);
        }
        public static void Main(string[] args)
    {
        BinaryTree ftree = new BinaryTree();
        var arr = new int[5] { 3, 1, 5, 2, 4 };

        int n = arr.Length;
        root = ftree.arraytotree(arr, 0, n - 1);

        Console.WriteLine("tree: ");
        ftree.print(root);
    }
    }

