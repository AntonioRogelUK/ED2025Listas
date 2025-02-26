using System.Text;

namespace ListasDoblementeLigadas
{
    internal class DoublyLinked
    {
        private NodoDoble? _nodoinicial;  // head
        private NodoDoble? _nodofinal;  // tail

        public DoublyLinked()
        {
            _nodoinicial = new NodoDoble();
            _nodofinal = new NodoDoble();
            _nodoinicial = null;
            _nodofinal = null;
        }

        public void Add(string dato)
        {
            NodoDoble NewNodo = new NodoDoble { Dato = dato };

            // Confirmar si la lista esta vacia
            if (_nodoinicial == null)
            {
                _nodoinicial = NewNodo;
                _nodofinal = NewNodo;
            }
            else
            {
                _nodofinal.Next = NewNodo;
                NewNodo.Back = _nodofinal;
                _nodofinal = NewNodo;
            }
        }

        public bool EstaVacio()
        {
            return _nodoinicial == null;
        }

        public void Vaciar()
        {
            _nodoinicial = null;
            _nodofinal = null;  // No estoy muy segura de este, no se si con solo apuntar el inicial a null baste... 
        }

        public NodoDoble? Buscar(string dato)
        {
            if (EstaVacio()) return null;
            NodoDoble? nodoActual = _nodoinicial;  // Confirmar si el nodo actual es el final (tail)

            while (nodoActual != null)
            {
                if (nodoActual.Dato == dato)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.Next;
            }
            return null;
        }

        public void Eliminar(string dato)
        {
            if (EstaVacio()) return;
            // Se busca cual dato hay que borrar primero
            NodoDoble? nodoABorrar = Buscar(dato);
            if (nodoABorrar != null)
            {
                if (nodoABorrar.Back != null)
                {
                    nodoABorrar.Back.Next = nodoABorrar.Next;
                }
                else
                {
                    _nodoinicial = nodoABorrar.Next;
                }
                if (nodoABorrar.Next != null)
                {
                    nodoABorrar.Next.Back = nodoABorrar.Back;
                }
                else
                {
                    _nodofinal = nodoABorrar.Back;
                }
            }
        }


        public string ObtenerValores()
        {
            if (EstaVacio()) return string.Empty;
            StringBuilder datos = new StringBuilder();
            NodoDoble? nodoActual = _nodoinicial;
            while (nodoActual != null)
            {
                datos.AppendLine(nodoActual.Dato);
                nodoActual = nodoActual.Next;
            }
            return datos.ToString();
        }

    }
}
