namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinked DoublyLinked = new DoublyLinked();

            DoublyLinked.Add("A");

            DoublyLinked.Add("B");
            DoublyLinked.Add("C");
            DoublyLinked.Add("D");
            DoublyLinked.Add("E");

            Console.WriteLine(DoublyLinked.ObtenerValores());

            DoublyLinked.Eliminar("A");

            Console.WriteLine();
            Console.WriteLine(DoublyLinked.ObtenerValores());
        }
    }
}
