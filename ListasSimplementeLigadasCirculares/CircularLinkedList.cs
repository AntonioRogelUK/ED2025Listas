using System.Text;

namespace ListasSimplementeLigadasCirculares
{
    internal class CircularLinkedList
    {
        private NodoCircular _nodoinicial;  // head
        private NodoCircular _nodofinal;  // tail

        public CircularLinkedList()
        {
            _nodoinicial = null;
            _nodofinal = null;
        }

        // Metodo para agregar dato al final (tail)
        public void Add(string dato)
        {
            NodoCircular NewNodo = new NodoCircular { Dato = dato };

            // Confirmar si la lista esta vacia
            if (_nodofinal == null)
            {
                _nodoinicial = NewNodo;
                _nodofinal = NewNodo;
                _nodofinal.Next = _nodoinicial;
            }
            else
            {
                _nodofinal.Next = NewNodo;
                _nodofinal = NewNodo;
                _nodofinal.Next = _nodoinicial;  // Aqui sucede la magia ✨ Asignando siguiente al nodo agregado para que conecte con el inicial
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

        public NodoCircular? Buscar(string dato)
        {
            if (EstaVacio()) return null;
            NodoCircular nodoActual = _nodoinicial;  // Confirmar si el nodo actual es el final (tail)

            do
            {
                if (nodoActual.Dato == dato)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.Next;
            } while (nodoActual != _nodoinicial);
            return null;
        }

        public void Eliminar(string dato)
        {
            if (EstaVacio()) return;
            NodoCircular nodoActual = _nodoinicial;
            NodoCircular nodoBack = _nodoinicial;
            do
            {
                if (nodoActual.Dato == dato)
                {
                    if (nodoActual == _nodoinicial)
                    {
                        _nodoinicial = _nodoinicial.Next;
                        _nodofinal.Next = _nodoinicial;
                    }
                    else if (nodoActual == _nodofinal)
                    {
                        _nodofinal = nodoBack;
                        _nodofinal.Next = _nodoinicial;
                    }
                    else
                    {
                        nodoBack.Next = nodoActual.Next;
                    }
                    return;
                }
                nodoBack = nodoActual;
                nodoActual = nodoActual.Next;
            } while (nodoActual != _nodoinicial);
        }

        public string ObtenerValores()
        {
            if (EstaVacio()) return string.Empty;
            StringBuilder datos = new StringBuilder();
            NodoCircular nodoActual = _nodoinicial;
            do
            {
                datos.AppendLine(nodoActual.Dato);
                nodoActual = nodoActual.Next;
            } while (nodoActual != _nodoinicial);
            return datos.ToString();
        }

    }
}
