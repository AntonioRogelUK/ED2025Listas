namespace ListasSimplementeLigadasCirculares
{
    internal class NodoCircular
    {
        public string Dato { get; set; } = string.Empty;
        public NodoCircular? Next { get; set; } = null; // Conexion con nodo siguiente
        public NodoCircular? Back { get; set; } = null; // Conexion con nodo anterior

    }
}
