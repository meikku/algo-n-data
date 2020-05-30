namespace part4
{
    using System;
    public class CircleGame
    {
        private Node head;
        private Node tail;

        public CircleGame()
        {
            this.head = null;
            this.tail = null;
        }
        public int Last(int n)
        {
            CreateCircle(n);
            return 0;
        }
        public void CreateCircle(int n)
        {
            if (n == 0)
            {
                return;
            }
            Node first = new Node(0, null, null);
            if (this.head == null)
            {
                this.head = first;
                this.tail = this.head;
                CreateCircle(n -1);
            }
            else
            {
                Node next = new Node(0, null, null);
                next = this.head;
                this.head = first;
                this.head.next = next;
                next.previous = this.head;
                this.head.previous = this.tail;
                this.tail.next = this.head;
                CreateCircle(n - 1);
            }
            Console.Write("* ");
        }
    }
}
