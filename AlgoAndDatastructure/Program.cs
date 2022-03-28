using AlgoAndDatastructure.BinaryTrees;
using System;
using System.Text.Json;

namespace AlgoAndDatastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(JsonSerializer.Serialize(BinaryTree.DepthFirstValues(SetUpTree())));
            Console.WriteLine(JsonSerializer.Serialize(BinaryTree.DepthFirstValuesRecursion(SetUpTree())));
            Console.WriteLine(JsonSerializer.Serialize(BinaryTree.BreadthFirstValues(SetUpTree())));
            Console.ReadLine();
        }

        static BinaryTreeNode SetUpTree()
        {
            var a = new BinaryTreeNode('a');
            var b = new BinaryTreeNode('b');
            var c = new BinaryTreeNode('c');
            var d = new BinaryTreeNode('d');
            var e = new BinaryTreeNode('e');
            var f = new BinaryTreeNode('f');

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            return a;
        }
    }


}
