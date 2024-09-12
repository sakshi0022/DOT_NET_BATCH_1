class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        list.InsertAtBegin(10);
        list.InsertAtBegin(20);
        list.InsertAtBegin(30);

        Console.WriteLine("Linked List:");
        list.DisplayList(); // Output: 30 20 10

        Console.WriteLine("Length of the list:");
        Console.WriteLine(list.Length()); // Output: 3

        list.InsertAtBegin(40);
        Console.WriteLine("Length of the list after adding another node:");
        Console.WriteLine(list.Length()); // Output: 4
    }
}
