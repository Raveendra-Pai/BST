


namespace BST
{
    class Node 
    {
        internal Node parent;
        internal Node left;
        internal Node right;
        public int data;
        

        public Node(int data)
        {
            this.parent = null;
            this.left = null;
            this.right = null;
            this.data = data;
        }

    }
}

