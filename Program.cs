using System;
using System.Collections.Generic;

namespace ConAppDoublyLList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist linkedlist = new Linkedlist();
            Node first = new Node
            {
                data = 12,
                next = null,
                prev = null
            };
            linkedlist.head = first;
            Node second = new Node

            {
                data = 20,
                next = null,

            };
            first.next = second;
            second.prev = first;
            Node third = new Node
            {
                data = 30,
                next = null
            };
            second.next = third;
            third.prev = second;
            linkedlist.PrintLlist();
            Console.ReadKey();
        }
    }
}