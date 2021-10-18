using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public override bool Equals(object obj)
        {
            var node = obj as TreeNode;

            if (node == null)
                return false;

            return node.Value == Value;
        }
    }

     

    public interface ITree
    {
        TreeNode GetRoot();
        void AddItem(int value); // добавить узел
        void RemoveItem(int value); // удалить узел по значению
        TreeNode GetNodeByValue(int value); //получить узел дерева по значению
        void PrintTree(); //вывести дерево в консоль
    }

    

   
    public static class TreeHelper
    {
        public static NodeInfo[] GetTreeInLine(ITree tree)
        {
            var bufer = new Queue<NodeInfo>();
            var returnArray = new List<NodeInfo>();
            var root = new NodeInfo() { Node = tree.GetRoot() };
            bufer.Enqueue(root);

            while (bufer.Count != 0)
            {
                var element = bufer.Dequeue();
                returnArray.Add(element);

                var depth = element.Depth + 1;

                if (element.Node.LeftChild != null)
                {
                    var left = new NodeInfo()
                    {
                        Node = element.Node.LeftChild,
                        Depth = depth,
                    };
                    bufer.Enqueue(left);
                }
                if (element.Node.RightChild != null)
                {
                    var right = new NodeInfo()
                    {
                        Node = element.Node.RightChild,
                        Depth = depth,
                    };
                    bufer.Enqueue(right);
                }
            }

            return returnArray.ToArray();
        }
    }

    public class BinaryTree
    {
        public TreeNode GetRoot { get; set; }
        
        

        public void AddItem(int value) 

        {
            var btr = this.GetRoot;
            var btrl = new BinaryTree();
            var btrr = new BinaryTree();
            if (btr == null)
            {
                btr = new TreeNode();
                btr.Value = value;
            }
            else if (btr.LeftChild == null)
            {
                btrl.GetRoot = btr.LeftChild;
                btrl.AddItem(value);
                
            }
            else if (btr.RightChild == null)
            {
                btrr.GetRoot = btr.RightChild;
                btrr.AddItem(value);

            }


        }

        public void RemoveItem(int value)
        {
            if (this.GetRoot == null)
            {
                return;
            }
            if (this.GetRoot.Value == value)
            {
                this.GetRoot = null;
                return;
            }

            else
            {
                this.GetRoot = this.GetRoot.LeftChild;
                this.GetRoot = this.GetRoot.RightChild;
            }

        }

        public void PrintTree()
        {
            var btr = this.GetRoot;
            var btrl = new BinaryTree();
            var btrr = new BinaryTree();

            
            if (btr != null)
            {
                btrl.GetRoot = btr.LeftChild;                
                btrr.GetRoot = btr.RightChild;             
                Console.WriteLine(btr.Value);
                btrl.PrintTree();
                btrr.PrintTree();


            }
            
        }





    }

    public class NodeInfo
    {
        public int Depth { get; set; }
        public TreeNode Node { get; set; }
    }


}
