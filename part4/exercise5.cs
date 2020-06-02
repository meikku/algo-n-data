namespace part4
{
    using System;
    public class BinarySearchTree
    {
        private Node root;
        private Node left;
        private Node right;
        public int maxHeightLeft = -1;
        public int maxHeightRight = -1;

        public void Add(int x)
        {
            Node next = new Node(x, null, null);
            if (root == null)
            {
                root = next;
            }
            if (x < root.value)
            {

                if (left == null)
                {
                    left = next;
                    next.previous = root;
                    maxHeightLeft++;
                }
                else
                {
                    next = new Node(x, null, left);
                }

            }

            if (right == null)
            {
                right = next;
                next.previous = root;
                maxHeightRight++;
            }
            else
            {
                next =  new Node(x, null, right);
                maxHeightRight++;
            }




        }
        public int Height()
        {
            if (root == null)
            {
                return -1;
            }
            if (left == null && right == null)
            {
                return 0;
            }
            
            if (maxHeightLeft > maxHeightRight)
            {
                return maxHeightLeft;
            }
            return maxHeightRight;

        }
    }
}
