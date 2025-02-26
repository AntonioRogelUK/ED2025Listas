namespace ListasDoblementeLigadas
{
    internal class NodoDoble
    {
        public string Dato { get; set; } = string.Empty;
        public NodoDoble? Next { get; set; } = null; // Conexion con nodo siguiente
        public NodoDoble? Back { get; set; } = null; // Conexion con nodo anterior
    }
}
