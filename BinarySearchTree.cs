


namespace BST
{
    class BinarySearchTree
    {

        Node root = null;

        public Node Search(int data)
        {
            return internalSearch(this.root, data);
        }

        private Node internalSearch(Node root, int data)
        {
            if (root is null || root.data == data)
            {
                return root;
            }

            if (root.data > data)
            {
                return internalSearch(root.left, data);
            }

            return internalSearch(root.right, data);

        }

        public void Insert(int data)
        {
            var newNode = new Node(data);

            if (this.root is null) {
                this.root = newNode;
                return;
            }

            InternalInsert(this.root, newNode);
        }

        private Node InternalInsert(Node root, Node newNode)
        {
            if (root is null)
            {
                return newNode;
            }

            if(newNode.data < root.data)
            {
                root.left = InternalInsert(root.left, newNode);
            } else if (newNode.data > root.data)
            {
                root.right = InternalInsert(root.right, newNode);
            }
                
            return root;
        }

        public void Delete(int data)
        {
            this.root = internalDelete(this.root, data);
        }

        private Node internalDelete(Node root, int key)
        {
            if (root is null)
            {
                return root;
            }

            if (key < root.data)
            {
                root.left =  internalDelete(root.left, key);
            } 
            else if (key > root.data)
            {
                root.right = internalDelete(root.right, key);
            }
            else
            {
                if (root.left is not null && root.right is null)
                {
                    root.data = root.left.data;
                    root.left = null;

                } 
                else if (root.right is not null && root.left is null)
                {
                    root.data = root.right.data;
                    root.right = null;
                }
                else
                {
                   var temp = GetNextSuccessorNode(root.right);
                    if (temp is null)
                    {
                        return temp;
                    }
                    root.data = temp.data;
                    root.right = internalDelete(root.right, temp.data);   
                }

            }

            return root;
        }

        public void PrintInOrder()
        {
            PrintInorderInternal(this.root);
        }

        public void PrintPostOrder()
        {
            PrintPostOrderInternal(this.root);
        }

        public void PrintPreOrder()
        {
            PrintPreOrderInternal(this.root);
        }

        private void PrintPreOrderInternal(Node root)
        {
            if (root is null)
            {
                return;
            }
            Console.WriteLine($"{root.data} ");
            PrintPreOrderInternal(root.left);
            PrintPreOrderInternal(root.right);   
        }

        private void PrintPostOrderInternal(Node root)
        {
            if (root is null)
            {
                return;
            }

            PrintPostOrderInternal(root.left);
            PrintPostOrderInternal(root.right);
            Console.WriteLine($"{root.data} ");
        }

        private void PrintInorderInternal(Node root)
        {
            if (root is not null)
            {
                PrintInorderInternal(root.left);
                Console.WriteLine($"{root.data} ");
                PrintInorderInternal(root.right);
            }
        }

        private Node GetNextSuccessorNode(Node root)
        {
            var current = root;

            while(current != null && current.left != null)
            {
                current = current.left;
            }
            return current;
        }

        internal void PrintRoot()
        {
            if (root is null)
            {
                Console.WriteLine("Empty Tree");
                return;
            }

            Console.WriteLine($"Root: {root.data}");
        }
    }
}

