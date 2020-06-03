namespace part4
{
    using System;
    using System.Collections.Generic;
    public class LinkedList
    {
        public Node head;
        private Node tail;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;

        }

        public void AddFirst(int n)
        {
            Node first = new Node(n, null, null);
            if (this.head == null)
            {
                this.head = first;
                this.tail = this.head;

            }
            else
            {
                // this.head.previous = first;
                // first.next = this.head;
                // this.head = first
                Node next = new Node(0, null, null);
                next = this.head;
                this.head = first;
                this.head.next = next;
                next.previous = this.head;

            }
        }
        public void AddLast(int n)
        {
            Node last = new Node(n, null, null);
            if (this.tail == null)
            {
                this.tail = last;
                this.head = this.tail;
               
            }

            else
            {
                // this.tail.next = last;
                // last.previous = this.tail;
                // this.tail = last;
                Node next = new Node(n, null, null);
                next = this.tail;
                this.tail = last;
                this.tail.previous = next;
                next.next = this.tail;
             
            }

        }
        public void RemoveFirst()
        {
            this.head = this.head.next;
            this.head.previous = null;
        }
        public void RemoveLast()
        {
            this.tail = this.tail.previous;
            this.tail.next = null;
        }
        public int GetNode(int x)
        {
            Node n = this.head;
            int i = 0;

            while (n != null)
            {
                if (i == x)
                {
                    return n.value;
                }
                n = n.next;
                i++;
            }
            return 0;

        }
        public override string ToString()
        {
            //   total = ""
            // n = head
            // while n is not null
            //  total += n.value + " "
            //  n = n.next
            // return total
            Node n = new Node(0, null, null);
            n = this.head;
            string returnValue = "";

            while (n != null)
            {
                returnValue = returnValue + n.value + " ";
                n = n.next;
            }

            return returnValue;
        }
    }
}
