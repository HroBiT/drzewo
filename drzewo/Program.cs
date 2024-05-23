internal class Program
{
    private static void Main(string[] args)
    {
        TreeNode root = new TreeNode(6);
        int[] valuesToAdd = { 4, 8, 5, 7, 9, 2, 3, 1 };

        foreach (var value in valuesToAdd)
        {
            root.Add(value);
        }

        Console.WriteLine(root.Search(7)?.Value);
    }

    public class TreeNode
    {
        public int Value { get; private set; }
        public TreeNode Left { get; private set; }
        public TreeNode Right { get; private set; }

        public TreeNode(int value)
        {
            Value = value;
        }

        public void Add(int value)
        {
            TreeNode targetNode = value % 2 == 0 ? Left : Right;

            if (targetNode == null)
            {
                if (value % 2 == 0)
                {
                    Left = new TreeNode(value);
                }
                else
                {
                    Right = new TreeNode(value);
                }
            }
            else
            {
                targetNode.Add(value);
            }
        }

        public TreeNode Search(int value)
        {
            if (Value == value)
            {
                return this;
            }

            TreeNode targetNode = value % 2 == 0 ? Left : Right;

            return targetNode?.Search(value);
        }
    }
}
