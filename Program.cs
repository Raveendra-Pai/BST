


namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var BST = new BinarySearchTree();
            BST.Insert(100);
            BST.Insert(90);
            BST.Insert(80);
            BST.Insert(70);
            BST.Insert(75);
            BST.Insert(110);
            BST.Insert(105);
            BST.Insert(120);
            Console.WriteLine("Tree before delete");
            BST.PrintInOrder();
            BST.Delete(100);
            Console.WriteLine("Tree after delete");
            BST.PrintInOrder();
            BST.PrintRoot();
        
        }
    }
}

