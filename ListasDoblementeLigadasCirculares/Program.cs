namespace ListasDoblementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularDoublyLinked CircularDoublyLinked = new CircularDoublyLinked();

            CircularDoublyLinked.Add("A");

            CircularDoublyLinked.Add("B");
            CircularDoublyLinked.Add("C");
            CircularDoublyLinked.Add("D");
            CircularDoublyLinked.Add("E");

            Console.WriteLine(CircularDoublyLinked.ObtenerValores());

            CircularDoublyLinked.Eliminar("D");

            Console.WriteLine();
            Console.WriteLine(CircularDoublyLinked.ObtenerValores());
        }
    }
}
