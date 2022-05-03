using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure.LinkedLists
{
    public class LinkedList
    {
        public int value;
        public LinkedList next;
        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }
    }

    internal class LinkedListAlgo
    {
        public static void PrintLinkedListValues(LinkedList head)
        {
            var currentNode = head;

            while (currentNode != null)
            {
                Console.Write(currentNode.value + " ");
                currentNode = currentNode.next;
            }
        }

        public static LinkedList InsertNodeAtBeginning(LinkedList head)
        {
            /*
             1. Create a new node to insert at the beginning
             2. Set the Next(pointer) of the new node to point at the head node
             3. Then set the head node to be the newly created node.
             
             */

            if(head == null)
            {
                return head;
            }

            LinkedList newNode = new LinkedList(8);
            newNode.next = head;
            head = newNode;

            return head;
        }

        public static LinkedList InsertNodeAfterAGiveNode(LinkedList prevNode, int newData)
        {
            /*
                Steps:
                    1. Create a new node
                    2. Set the pointer of the new node to point at the next of the previous node
                    3. Set the pointer of the previous node to point at the new node
            */


            if(prevNode == null)
            {
                return prevNode;
            }

            var newNode = new LinkedList(newData);
            newNode.next = prevNode.next;
            prevNode.next = newNode;

            return prevNode;
        }

        public static LinkedList AddNodeAtTheEndO(LinkedList head, int newData)
        {
            /*
                Steps:
                1. Create the new node to add at the end of the linked list
                2. Traverse the head until the end.
                3. Set the pointer of the last node to the new node
             */

            if(head == null)
            {
                head = new LinkedList(newData);
                return head;
            }

            LinkedList newNode = new LinkedList(newData);

            var currentNode = head;

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = newNode;

            return head;
        }
       
        public static LinkedList DeleteNode(LinkedList head, int val)
        {
            if(head == null)
            {
                return null;
            }

            if (head.value == val)
            {
                head = head.next;
                return head;
            }

            var tempNode = head;
            LinkedList prevNode = null;

            while (tempNode != null)
            {
                if(tempNode.value == val)
                {
                    prevNode.next = tempNode.next;
                    break;
                }

                prevNode = tempNode;
                tempNode = tempNode.next;
            }

            return head;
            
        }

        public static LinkedList DeleteNodeAtAGivenposition(LinkedList head, int val)
        {
            if (head == null)
            {
                return null;
            }

            int positon = 0;

            if (positon == val)
            {
                head = head.next;
                return head;
            }

            var tempNode = head;
            LinkedList prevNode = null;

            while (tempNode != null)
            {
                if (positon == val)
                {
                    prevNode.next = tempNode.next;
                    break;
                }

                prevNode = tempNode;
                tempNode = tempNode.next;
                positon++;
            }

            return head;

        }

        public static int GetNthNode(LinkedList head, int index)
        {
            if (head == null)
            {
                return 0;
            }

            int counter = 0;

            if (counter == index)
            {
                return head.value;
            }

            var tempNode = head;

            while (tempNode != null)
            {
                if (counter == index)
                {
                    return tempNode.value;
                }

                tempNode = tempNode.next;
                counter++;
            }

            return 0;

        }
        
        public static int GetNthNodeValueFromListEnd(LinkedList head, int n)
        {
            if(head == null)
            {
                throw new ArgumentException();
            }

            LinkedList firstPointer = head;
            LinkedList secondPointer = head;

            int counter = 1;

            while (counter <= n && secondPointer != null)
            {
                secondPointer = secondPointer.next;
                counter++;
            }

            if(secondPointer == null)
            {
                return firstPointer.next.value;
            }

            while (secondPointer.next != null)
            {
                firstPointer = firstPointer.next;
                secondPointer = secondPointer.next;
            }

            return firstPointer.next.value;
        }

        public static int FindTheMiddleOfLinkedList(LinkedList head)
        {
            if (head == null)
            {
                throw new ArgumentException();
            }

            double len = 0;

            var tempNode = head;

            while (tempNode != null)
            {
                tempNode = tempNode.next;
                len++;
            }

            double middle = 0;

            if (len == 1)
            {
                return head.value;
            }

            if (len == 2)
            {
                return head.next.value;
            }

            if(len % 2 == 0)
            {
                middle = (len / 2) + 1;

            }
            else
            {
                middle = (len / 2) + 0.5;
            }

            tempNode = head;
            int counter = 1;
            while(tempNode != null)
            {
                if(middle == counter)
                {
                    return tempNode.value;
                }

                tempNode = tempNode.next;
                counter++;
            }

            return -1;
        }

        //public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList head)
        //{

        //}
    }
}
