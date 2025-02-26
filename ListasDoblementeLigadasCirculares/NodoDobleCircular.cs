namespace ListasDoblementeLigadasCirculares
{
    internal class NodoDobleCircular
    {
        public string Dato { get; set; } = string.Empty;
        public NodoDobleCircular? Next { get; set; } = null; // Conexion con nodo siguiente
        public NodoDobleCircular? Back { get; set; } = null; // Conexion con nodo anterior
    }
}
