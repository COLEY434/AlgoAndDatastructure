using AlgoAndDatastructure.Arrays;
using AlgoAndDatastructure.BinaryTrees;
using AlgoAndDatastructure.GrokkingAlgorithmByA;
using AlgoAndDatastructure.LinkedLists;
using AlgoAndDatastructure.Neetcode;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace AlgoAndDatastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(JsonSerializer.Serialize(ArraysAndHashing.TopKFrequent(new int[] { 1 }, 1)));
             //Console.WriteLine(SlidingWindow.SmallestSubArrayWithAGivenSum(new int[]{ 2, 1, 5, 2, 3, 2 }, 7));
            Console.WriteLine(SlidingWindow.LongestSubStringWithKDistinctCharacters("cbbebi", 3));
            Console.ReadLine();
        }

        static LinkedList SetUpLinkedList()
        {         
            var newLinkedList = new LinkedList(10);
            newLinkedList.next = new LinkedList(20);
            newLinkedList.next.next = new LinkedList(30);
            newLinkedList.next.next.next = new LinkedList(40);
            newLinkedList.next.next.next.next = new LinkedList(50);
            newLinkedList.next.next.next.next.next = new LinkedList(60);

            return newLinkedList;
        }
        static BinaryTreeNode SetUpTree()
        {
            var a = new BinaryTreeNode('4');
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

        static BinaryTreeNumber SetUpTreeNum()
        {
            var a = new BinaryTreeNumber(5);
            var b = new BinaryTreeNumber(10);
            var c = new BinaryTreeNumber(15);
            var d = new BinaryTreeNumber(20);
            var e = new BinaryTreeNumber(25);
            var f = new BinaryTreeNumber(70);

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            return a; 
        }
    }


}
