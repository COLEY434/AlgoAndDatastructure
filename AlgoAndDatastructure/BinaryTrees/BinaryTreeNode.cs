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

    public class BinaryTreeNumber
    {
        public int Value { get; set; }
        public BinaryTreeNumber Left { get; set; }
        public BinaryTreeNumber Right { get; set; }

        public BinaryTreeNumber(int value)
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
    
        public static bool FindTarget(BinaryTreeNode rootNode, char target)
        {
            if(rootNode == null)
            {
                return false;
            }

            var queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(rootNode);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                if(currentNode.Value == target)
                {
                    return true;
                }

                if(currentNode.Left != null) queue.Enqueue(currentNode.Left);
                if(currentNode.Right != null) queue.Enqueue(currentNode.Right);
            }

            return false;
        }

        public static bool FindTargetRecursion(BinaryTreeNode rootNode, char target)
        {
            if (rootNode == null)
            {
                return false;
            }

            if(rootNode.Value == target)
            {
                return true;
            }
      
            return FindTargetRecursion(rootNode.Left, target) || FindTargetRecursion(rootNode.Right, target);
        }

        public static int SumAllNumbers(BinaryTreeNumber rootNode)
        {
            if (rootNode == null)
            {
                return 0;
            }
        
            return rootNode.Value + SumAllNumbers(rootNode.Left) + SumAllNumbers(rootNode.Right);
        }

        public static int FindMininumValue(BinaryTreeNumber rootNode)
        {

            var queue = new Queue<BinaryTreeNumber>();
            queue.Enqueue(rootNode);

            int smallest = int.MaxValue;

            while(queue.Count > 0)
            {
                var currNode = queue.Dequeue();
                smallest = Math.Min(smallest, currNode.Value);

                if (currNode.Left != null) queue.Enqueue(currNode.Left);
                if (currNode.Right != null) queue.Enqueue(currNode.Right);
            }

            return smallest;
        }

        public static int FindMininumValueRecursion(BinaryTreeNumber rootNode)
        {
            if(rootNode == null)
            {
                return int.MaxValue;
            }
            var left = FindMininumValueRecursion(rootNode.Left);
            var right = FindMininumValueRecursion(rootNode.Right);

            var smallest = Math.Min(left, right);
            smallest = Math.Min(smallest, rootNode.Value);

            return smallest;
        }

        public static int MaxRootToLeafPathSum(BinaryTreeNumber rootNode)
        {
            if (rootNode == null)
            {
                return int.MinValue;
            }

            if(rootNode.Left == null && rootNode.Right == null)
            {
                return rootNode.Value;
            }
            var left = MaxRootToLeafPathSum(rootNode.Left);
            var right = MaxRootToLeafPathSum(rootNode.Right);
         
            return rootNode.Value + Math.Max(left, right);
        }
    }
}
