namespace Task01_TreeOfNNodes
{
    using System;
    using System.Linq;

    internal class Startup
    {
        internal static void Main()
        {
            Console.WriteLine("N = ");
            var n = int.Parse(Console.ReadLine());

            var nodes = new TreeNode<int>[n];
            for (int i = 0; i < n; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("Enter parent and child node [separated by spaces] ");
                var input = Console.ReadLine().Split(' ');
                var parentValue = int.Parse(input[0]);
                var childValue = int.Parse(input[1]);

                nodes[parentValue].AddChild(nodes[childValue]);
            }

            Console.WriteLine("Root node: ");
            var rootNode = nodes.FirstOrDefault(x => x.HasParent == false);
            if (rootNode != null)
            {
                Console.WriteLine(rootNode.Value);
            }

            Console.WriteLine("Leaf nodes: ");
            var leafNodes = nodes.Where(x => x.Children.Count == 0).ToList();
            leafNodes.ForEach(x => Console.WriteLine(x.Value));

            Console.WriteLine("Middle nodes: ");
            var middleNodes = nodes.Where(x => x.Children.Count != 0 && x.HasParent).ToList();
            middleNodes.ForEach(x => Console.WriteLine(x.Value));

            Console.WriteLine("Max depth: " + TreeDepthCalculate(rootNode));            
        }

        public static int TreeDepthCalculate(TreeNode<int> root)
        {
            if (root == null)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var child in root.Children)
            {
                maxPath = Math.Max(maxPath, TreeDepthCalculate(child));
            }

            return maxPath + 1;
        }
    }
}
