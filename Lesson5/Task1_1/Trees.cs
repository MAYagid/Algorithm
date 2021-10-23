using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
   public class Node
    {
        public Node left;
        public Node right;
        public int Value;
        public Node(int value, Node left, Node right)
        {
            this.Value = value;
            this.left = left;
            this.right = right;
        }
        public Node(int value)
        {
            this.Value = value;
            this.left = null;
            this.right = null;
        }

        public static void bfs(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.WriteLine(node.Value);

                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
            }
        }

        public static void dfs(Node node)
        {
            if (node == null) return;
            Console.WriteLine(node.Value);
            dfs(node.left);
            dfs(node.right);
        }


    }

    

    


}
