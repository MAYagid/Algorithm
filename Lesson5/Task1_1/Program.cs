using System;

namespace Task1_1
{
    class Program
    {
        static Node Test_tree()
        {
            Node root = new Node(10,
                new Node(100,
                    new Node(4, new Node(45), null),
                    new Node(50)),
                new Node(1,
                    new Node(0),
                    new Node(19))
                );
            return root;
        }
        static int Main(string[] args)
        {
            var tree = Test_tree();
            Console.WriteLine("BFS:");
            Node.bfs(tree);
            Console.WriteLine("DFS:");
            Node.dfs(tree);
            return 0;
        }
        
       
    }
}
