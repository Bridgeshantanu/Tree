namespace DataStructure2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);
            bst.Add(40);
            bst.Add(80);
            bst.Add(20);
            bst.Add(10);
            bst.Add(60);
            bst.Display();
            Console.WriteLine("\n");
            int size = bst.Size();
            Console.WriteLine("Size: " + size);

        }
    }
}