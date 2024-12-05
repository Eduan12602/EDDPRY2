using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Circular_Doble // Define el espacio de nombres para la lista circular doble.
{
    internal class ListaCircularDoble // Clase que implementa la lista circular doblemente enlazada.
    {
        public Nodo Inicio { get; set; } // Nodo que apunta al inicio de la lista.
        public Nodo Fin { get; set; }    // Nodo que apunta al final de la lista.

        public ListaCircularDoble() // Constructor para inicializar la lista vacía.
        {
            Inicio = null; // Inicializa el nodo de inicio como nulo.
            Fin = null;    // Inicializa el nodo de fin como nulo.
        }

        // Función para insertar un nodo en una posición específica.
        public void Insertar(int posicion, int dato)
        {
            Nodo nuevo = new Nodo(dato); // Crea un nuevo nodo con el dato proporcionado.

            if (Inicio == null && Fin == null) // Caso: la lista está vacía.
            {
                Inicio = nuevo; // El nuevo nodo es el inicio.
                Fin = nuevo;    // El nuevo nodo es también el fin.
                nuevo.Sig = nuevo; // El nodo se apunta a sí mismo como siguiente (circularidad).
                nuevo.Prev = nuevo; // El nodo se apunta a sí mismo como anterior (circularidad).
            }
            else if (posicion == 0 || posicion == 1) // Caso: insertar al inicio de la lista.
            {
                nuevo.Sig = Inicio; // El nuevo nodo apunta al nodo actual de inicio.
                nuevo.Prev = Fin;   // El nuevo nodo apunta al nodo de fin como anterior.
                Inicio.Prev = nuevo; // El nodo de inicio actual apunta al nuevo nodo como anterior.
                Fin.Sig = nuevo;    // El nodo de fin apunta al nuevo nodo como siguiente.
                Inicio = nuevo;     // Actualiza el inicio de la lista al nuevo nodo.
            }
            else // Caso: insertar en cualquier otra posición.
            {
                int pos = 1; // Variable para rastrear la posición actual.
                Nodo aux = Inicio; // Nodo auxiliar para recorrer la lista.

                // Recorre la lista hasta encontrar la posición o llegar al inicio nuevamente.
                while (pos < posicion && aux.Sig != Inicio)
                {
                    aux = aux.Sig; // Avanza al siguiente nodo.
                    pos++;         // Incrementa la posición.
                }

                if (aux != null) // Si encuentra una posición válida.
                {
                    nuevo.Sig = aux; // El nuevo nodo apunta al nodo actual.
                    nuevo.Prev = aux.Prev; // El nuevo nodo apunta al nodo anterior del actual.
                    aux.Prev.Sig = nuevo; // El nodo anterior apunta al nuevo nodo como siguiente.
                    aux.Prev = nuevo;     // El nodo actual apunta al nuevo nodo como anterior.
                }
            }
        }

        // Función para eliminar un nodo de una posición específica.
        public int Eliminar(int posicion)
        {
            if (Inicio == null && Fin == null) // Caso: la lista está vacía.
            {
                return 0; // Retorna 0 indicando que no hay elementos para eliminar.
            }

            int pos = 1; // Variable para rastrear la posición actual.
            Nodo aux = Inicio; // Nodo auxiliar para recorrer la lista.

            // Recorre la lista hasta encontrar la posición o llegar al inicio nuevamente.
            while (pos < posicion && aux.Sig != Inicio)
            {
                aux = aux.Sig; // Avanza al siguiente nodo.
                pos++;         // Incrementa la posición.
            }

            if (aux != null) // Si encuentra el nodo en la posición deseada.
            {
                if (aux == Inicio && aux == Fin) // Caso: solo hay un nodo en la lista.
                {
                    Inicio = null; // La lista queda vacía.
                    Fin = null;    // La lista queda vacía.
                }
                else if (aux == Inicio) // Caso: el nodo a eliminar es el inicio.
                {
                    Inicio = aux.Sig;    // El siguiente nodo se convierte en el inicio.
                    Fin.Sig = Inicio;    // El nodo de fin apunta al nuevo inicio.
                    Inicio.Prev = Fin;   // El nuevo inicio apunta al nodo de fin como anterior.
                }
                else if (aux == Fin) // Caso: el nodo a eliminar es el fin.
                {
                    Fin = aux.Prev;     // El nodo anterior se convierte en el fin.
                    Fin.Sig = Inicio;  // El nuevo fin apunta al inicio como siguiente.
                    Inicio.Prev = Fin; // El inicio apunta al nuevo fin como anterior.
                }
                else // Caso: el nodo a eliminar está en el medio.
                {
                    aux.Prev.Sig = aux.Sig; // El nodo anterior apunta al siguiente del nodo eliminado.
                    aux.Sig.Prev = aux.Prev; // El nodo siguiente apunta al anterior del nodo eliminado.
                }

                return aux.Dato; // Retorna el dato del nodo eliminado.
            }

            return 0; // Si no se encuentra la posición, retorna 0.
        }
    }
}
