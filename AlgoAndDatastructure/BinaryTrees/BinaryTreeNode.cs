using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure.BinaryTrees
{
    public class BinaryTreeNode
    {
        public char Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode(char value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public static List<char> DepthFirstValues(BinaryTreeNode rootNode)
        {
            if(rootNode == null)
            {
                return new List<char>();
            }

            var rtnList = new List<char>();
            var stack = new Stack<BinaryTreeNode>();
            stack.Push(rootNode);

            while(stack.Count > 0)
            {
                var currentNode = stack.Pop();
                rtnList.Add(currentNode.Value);
  

                if(currentNode.Right != null) stack.Push(currentNode.Right);
                if(currentNode.Left != null) stack.Push(currentNode.Left);
            }

            return rtnList;
        }

        public static List<char> DepthFirstValuesRecursion(BinaryTreeNode rootNode)
        {
            if (rootNode == null)
            {
                return new List<char>();
            }

            var rtnList = new List<char>();

            var rightValues = DepthFirstValuesRecursion(rootNode.Right);
            var leftValues = DepthFirstValuesRecursion(rootNode.Left);

            rtnList.Add(rootNode.Value);
            rtnList.AddRange(leftValues);
            rtnList.AddRange(rightValues);
            return rtnList;
        }

        public static List<char> BreadthFirstValues(BinaryTreeNode rootNode)
        {
            if (rootNode == null)
            {
                return new List<char>();
            }

            var rtnList = new List<char>();

            var queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(rootNode);

            while(queue.Count > 0)
            {
                BinaryTreeNode currentNode = queue.Dequeue();
                rtnList.Add(currentNode.Value);

                if(currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if(currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

           
            return rtnList;
        }
    }
}
