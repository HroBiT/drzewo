using System;

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class CustomBinaryTree
{
    private TreeNode root;

    public CustomBinaryTree()
    {
        root = null;
    }

    public void Add(int value)
    {
        if (root == null)
        {
            root = new TreeNode(value);
        }
        else
        {
            AddRecursively(root, value);
        }
    }

    private void AddRecursively(TreeNode node, int value)
    {
        if (value % 2 == 0)
        {
            if (node.Left == null)
            {
                node.Left = new TreeNode(value);
            }
            else
            {
                AddRecursively(node.Left, value);
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new TreeNode(value);
            }
            else
            {
                AddRecursively(node.Right, value);
            }
        }
    }

    public bool Search(int value)
    {
        return SearchRecursively(root, value);
    }

    private bool SearchRecursively(TreeNode node, int value)
    {
        if (node == null)
        {
            return false;
        }

        if (node.Value == value)
        {
            return true;
        }

        if (value % 2 == 0)
        {
            return SearchRecursively(node.Left, value);
        }
        else
        {
            return SearchRecursively(node.Right, value);
        }
    }

    public void InOrderTraversal()
    {
        InOrderTraversalRecursively(root);
        Console.WriteLine();
    }

    private void InOrderTraversalRecursively(TreeNode node)
    {
        if (node != null)
        {
            InOrderTraversalRecursively(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversalRecursively(node.Right);
        }
    }
}

class Program
{
    static void Main()
    {
        CustomBinaryTree tree = new CustomBinaryTree();

        tree.Add(1);
        tree.Add(2);
        tree.Add(3);
        tree.Add(4);
        tree.Add(5);
        tree.Add(6);
        tree.Add(7);
        tree.Add(8);
        tree.Add(9);
        tree.Add(10);

        Console.WriteLine("drzewo:");
        tree.InOrderTraversal();

    }
}
