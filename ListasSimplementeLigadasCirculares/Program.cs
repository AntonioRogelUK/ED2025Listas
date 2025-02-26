namespace ListasSimplementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList CircularLinkedList = new CircularLinkedList();

            CircularLinkedList.Add("A");

            CircularLinkedList.Add("B");
            CircularLinkedList.Add("C");
            CircularLinkedList.Add("D");
            CircularLinkedList.Add("E");

            Console.WriteLine(CircularLinkedList.ObtenerValores());

            CircularLinkedList.Eliminar("C");

            Console.WriteLine();
            Console.WriteLine(CircularLinkedList.ObtenerValores());
        }
    }
}

