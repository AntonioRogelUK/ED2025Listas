using System.Text;

namespace ListasDoblementeLigadasCirculares
{
    internal class CircularDoublyLinked
    {
        private NodoDobleCircular? _nodoinicial;  // head
        private NodoDobleCircular? _nodofinal;  // tail

        public CircularDoublyLinked()
        {
            _nodoinicial = new NodoDobleCircular();
            _nodofinal = new NodoDobleCircular();
            _nodoinicial = null;
            _nodofinal = null;
        }

        public void Add(string dato)
        {
            NodoDobleCircular NewNodo = new NodoDobleCircular { Dato = dato };

            // Confirmar si la lista esta vacia
            if (_nodoinicial == null)
            {
                _nodoinicial = NewNodo;
                _nodofinal = NewNodo;
                _nodoinicial.Next = _nodoinicial;
                _nodoinicial.Back = _nodoinicial;
            }
            else
            {
                _nodofinal.Next = NewNodo;
                NewNodo.Back = _nodofinal;
                NewNodo.Next = _nodoinicial;
                _nodoinicial.Back = NewNodo;
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

        public NodoDobleCircular? Buscar(string dato)
        {
            if (EstaVacio()) return null;
            NodoDobleCircular? nodoActual = _nodoinicial;  // Confirmar si el nodo actual es el final (tail)

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
            // Se busca cual dato hay que borrar primero
            NodoDobleCircular? nodoABorrar = Buscar(dato);
            if (nodoABorrar != null)
            {
                if (nodoABorrar.Back != _nodoinicial && nodoABorrar == _nodofinal)
                {
                    _nodoinicial = null;
                    _nodofinal = null;
                }
                else
                {
                    nodoABorrar.Back.Next = nodoABorrar.Next;
                    nodoABorrar.Next.Back = nodoABorrar.Back;

                    if (nodoABorrar == _nodoinicial)
                    {
                        _nodoinicial = nodoABorrar.Next;
                    }
                    if (nodoABorrar == _nodofinal)
                    {
                        _nodofinal = nodoABorrar.Back;
                    }
                }
            }
        }


        public string ObtenerValores()
        {
            if (EstaVacio()) return string.Empty;
            StringBuilder datos = new StringBuilder();
            NodoDobleCircular? nodoActual = _nodoinicial;
            do
            {
                datos.AppendLine(nodoActual!.Dato);
                nodoActual = nodoActual.Next;
            } while (nodoActual != _nodoinicial);
            return datos.ToString();
        }

    }
}


