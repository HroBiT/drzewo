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

    // Metoda do dodawania nowego elementu
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
            // Dodawanie do lewego poddrzewa dla wartości parzystych
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
            // Dodawanie do prawego poddrzewa dla wartości nieparzystych
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

    // Metoda do wyszukiwania elementu
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
            // Wyszukiwanie w lewym poddrzewie dla wartości parzystych
            return SearchRecursively(node.Left, value);
        }
        else
        {
            // Wyszukiwanie w prawym poddrzewie dla wartości nieparzystych
            return SearchRecursively(node.Right, value);
        }
    }

    // Metoda do wyświetlania drzewa (in-order traversal)
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
        
        // Dodawanie elementów do drzewa
        tree.Add(10);
        tree.Add(15);
        tree.Add(8);
        tree.Add(20);
        tree.Add(13);
        tree.Add(7);
        tree.Add(22);

        // Wyświetlanie drzewa
        Console.WriteLine("In-order traversal:");
        tree.InOrderTraversal();

        // Wyszukiwanie elementów w drzewie
        Console.WriteLine("Search 15: " + tree.Search(15)); // true
        Console.WriteLine("Search 21: " + tree.Search(21)); // false
    }
}
