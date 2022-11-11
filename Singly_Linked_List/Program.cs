﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    //each node consist of the information part and link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote() //add a node in the list
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student : ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = nim;
            newnode.name = nm;
            //if the node to be inserted is the first node
            if (START == null || nim <= START.rollNumber)
            {
                if ((START != null) && (nim == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            // locate the position of the new node in the list
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.rollNumber))
            {
                if (nim == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                previous = current;
                current = current.next;
            }

            /*once the above for loop is executed, prev and current are positioned in such a manner that the position for the new node */
            newnode.next = current;
            previous.next = newnode;
        }
        public void traverse()
        {
            if (ListEmpty())
            {
                Console.WriteLine("\nList is empt. \n");
            }
            else
            {
                Console.WriteLine("\nList record in the list are : ");
                Node currentNode;
                for (currentNode = START; currentNode != null; 
                    currentNode = currentNode.next) ;
                Console.WriteLine(currentNode.rollNumber + "" + currentNode.name + "\n");
                Console.WriteLine();
            }
        }
    }
}
