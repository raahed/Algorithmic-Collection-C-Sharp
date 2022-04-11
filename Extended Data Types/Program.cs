namespace Extended_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList linkedList = new SingleLinkedList("Das", "ist", "ein", "Test");

            if (linkedList.Last != null)
                Console.WriteLine("Wow");

            linkedList.RemoveFirst();

            Console.WriteLine("Wow");

            Console.WriteLine(linkedList.Find("ist"));
        }
    }
}
