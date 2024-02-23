using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Tree
    {
        //Expected Output: 1 7 14 23 28 5 2 9 21 18 17 6 4
        public static void GetBoundaryOfPerfectBinaryTree()
        {
            //Then the order of nodes printed should be: 1 7 14 23 28 5 2 9 21 18 17 6 4
            int[] tree = { 1, 7, 14, 23, 28, 8, 5, 2, 4, 3, 9, 21, 6, 18, 17 };
            List<int> nodes = BoundaryOfPerfectBinaryTree(tree, 4);

            foreach (int node in nodes)
            {
                Console.WriteLine(node);
            }
        }
        public static List<int> BoundaryOfPerfectBinaryTree(int[] tree, int depth)
        {
            List<int> boundary = [];
            if (tree == null || tree.Length == 0) return boundary;

            List<List<int>> levels = new(depth + 1);
            levels.Add(new List<int>());

            Visit(new Queue<int>(tree), 1, depth, levels);

            CollectLeftBoundary(levels, depth, boundary);
            CollectLeaves(levels, depth, boundary);
            CollectRightBoundary(levels, depth, boundary);

            return boundary;
        }

        private static void Visit(Queue<int> nodes, int depth, int maxDepth, List<List<int>> levels)
        {
            if (depth > maxDepth) return;

            if (depth == levels.Count)
            {
                levels.Add(new List<int>());
            }

            levels[depth].Add(nodes.Dequeue());

            Visit(nodes, depth + 1, maxDepth, levels);
            Visit(nodes, depth + 1, maxDepth, levels);
        }

        private static void CollectLeftBoundary(List<List<int>> levels, int maxDepth, List<int> boundary)
        {
            for (int depth = 1; depth <= maxDepth; depth++)
            {
                boundary.Add(levels[depth][0]);
            }
        }

        private static void CollectLeaves(List<List<int>> levels, int maxDepth, List<int> boundary)
        {
            List<int> lastLevel = levels[maxDepth];
            for (int i = 1; i < lastLevel.Count - 1; i++)
            {
                boundary.Add(lastLevel[i]);
            }
        }

        private static void CollectRightBoundary(List<List<int>> levels, int maxDepth, List<int> boundary)
        {
            for (int depth = maxDepth; depth > 1; depth--)
            {
                List<int> level = levels[depth];
                boundary.Add(level[level.Count - 1]);
            }
        }
    }
}
