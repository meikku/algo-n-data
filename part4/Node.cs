namespace part4
{
    using System;
    public class Node
    {
        public int value;
        public Node next;
        public Node previous;

        public Node(int value, Node next, Node previous)
        {
            this.value = value;
            this.next = next;
            this.previous = previous;
        }
    }
}
