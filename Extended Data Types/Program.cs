namespace Extended_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList("Das", "ist", "ein", "Test");

            if (linkedList.Last != null)
                Console.WriteLine("Wow");

            linkedList.RemoveFirst();

            Console.WriteLine("Wow");

            Console.WriteLine(linkedList.Find("ist"));
        }
    }
}
