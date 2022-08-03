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
            //    List<object> test = new List<object>(){
            //    5,
            //    2,
            //    new List<object>(){
            //        7, -1
            //    },
            //    3,
            //    new List<object>(){
            //        6,
            //        new List<object>(){
            //            -13, 8
            //        },
            //        4,
            //    },
            //};
            //Console.WriteLine("Hello World!");
            // LinkedListAlgo.PrintLinkedListValues(SetUpLinkedList());
            //LinkedListAlgo.PrintLinkedListValues(LinkedListAlgo.InsertNodeAtBeginning(SetUpLinkedList()));
            //LinkedListAlgo.PrintLinkedListValues(LinkedListAlgo.DeleteNodeAtAGivenposition(SetUpLinkedList(), 3));
            //Console.WriteLine(ArrAlgoExpertEasy.ProductSum(test));
            //Console.WriteLine(ArrAlgoExpertEasy.GetFibNumber2(6));

            //int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
            //                          { { 7, 8, 9 }, { 10, 11, 12 } } };

            //int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            ////Console.WriteLine(JsonSerializer.Serialize(CodePractice.InsertElementAtSpecificPosition(new int[9], 4, 9)));

            //Console.WriteLine(array2Da.GetLength());
            // Console.WriteLine(array3Da.Rank);

            Console.WriteLine(JsonSerializer.Serialize(ArraysAndHashing.TopKFrequent(new int[] { 1 }, 1)));


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
