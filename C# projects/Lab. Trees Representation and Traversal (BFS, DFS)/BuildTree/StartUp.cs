using System.Collections.Generic;
using SimpleTreeNode;

namespace BuildTree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            TreeNode<char> tre = new TreeNode<char>('A',
                new TreeNode<char>('B',
                    new TreeNode<char>('D',
                        new TreeNode<char>('H'),
                        new TreeNode<char>('I')
                    ),
                    new TreeNode<char>('E')
                ),
                new TreeNode<char>('C',
                    new TreeNode<char>('F',
                        new TreeNode<char>('J')
                    ),
                    new TreeNode<char>('G')
                )
            );

            TreeNode<int> tree = new TreeNode<int>(25,
                new TreeNode<int>(20,
                    new TreeNode<int>(10,
                        new TreeNode<int>(5,
                            new TreeNode<int>(1),
                            new TreeNode<int>(8)
                        ),
                        new TreeNode<int>(12,
                            new TreeNode<int>(15)
                        ),
                        new TreeNode<int>(22)
                    )
                ),
                new TreeNode<int>(36,
                    new TreeNode<int>(30,
                        new TreeNode<int>(28)
                    ),
                    new TreeNode<int>(40,
                        new TreeNode<int>(38),
                        new TreeNode<int>(48,
                            new TreeNode<int>(45),
                            new TreeNode<int>(50)
                        )
                    )
                )
            );

            Console.WriteLine(tre.ToString());
            Console.WriteLine(tree.ToString());
        }
    }
}
