using System;
using System.Linq;
using System.Collections.Generic;
using SimpleTreeNode;

namespace Hierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            TreeNode<string> tree = new TreeNode<string>("Boss",
                new TreeNode<string>("Sarah",
                    new TreeNode<string>("Lora"),
                    new TreeNode<string>("Viktor")
                ),
                new TreeNode<string>("Evan",
                    new TreeNode<string>("Cole",
                        new TreeNode<string>("Mary"),
                        new TreeNode<string>("Clare")
                    ),
                    new TreeNode<string>("Nicole",
                        new TreeNode<string>("Alex",
                            new TreeNode<string>("Peter")
                        ),
                        new TreeNode<string>("Anya")
                    )
                ),
                new TreeNode<string>("Mike")
            );

            string nameToFind = Console.ReadLine();

            //Console.WriteLine(tree.ToString());
            BFS(tree, nameToFind);
        }

        public static void BFS(TreeNode<string> root, string nameToFind)
        {
            Queue<TreeNode<string>> visitedNodesQueue = new Queue<TreeNode<string>>();
            visitedNodesQueue.Enqueue(root);

            while (visitedNodesQueue.Count > 0)
            {
                TreeNode<string> currentNode = visitedNodesQueue.Dequeue();
                Console.WriteLine(currentNode.Value);

                if (currentNode.Value == nameToFind)
                {
                    return;
                }

                foreach (var child in currentNode.ChildNodes)
                {
                    visitedNodesQueue.Enqueue(child);
                }
            }
        }
    }
}
