using System;


namespace ConAppDoublyLList
{
    public class Linkedlist
    {
        public Node head;
        public Linkedlist()
        {
            head = null;
        }
        public void PrintLlist()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("the List Contains: ");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("This DoublylList is empty");
            }
        }
    }
}