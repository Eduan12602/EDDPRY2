using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ColaDinamica // Define el espacio de nombres para la clase de cola dinámica.
{
    internal class Cola // Clase que representa una estructura de datos tipo Cola (FIFO).
    {
        private Nodo inicio; // Nodo que apunta al primer elemento de la cola.
        private Nodo final;  // Nodo que apunta al último elemento de la cola.

        public Cola() // Constructor para inicializar la cola vacía.
        {
            inicio = null; // Inicializa el nodo inicio como nulo.
            final = null;  // Inicializa el nodo final como nulo.
        }

        // Método para agregar un elemento al final de la cola.
        public void Encolar(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato); // Crea un nuevo nodo con el dato proporcionado.
            if (final == null) // Si la cola está vacía.
            {
                inicio = nuevoNodo; // El nuevo nodo se convierte en el inicio.
                final = nuevoNodo;  // El nuevo nodo también se convierte en el final.
            }
            else
            {
                final.Siguiente = nuevoNodo; // Enlaza el nuevo nodo al final de la cola.
                final = nuevoNodo;          // Actualiza el final de la cola al nuevo nodo.
            }
        }

        // Método para eliminar el primer nodo de la cola.
        public string Desencolar()
        {
            if (inicio == null) // Si la cola está vacía.
            {
                return null; // Retorna null indicando que no hay elementos para desencolar.
            }

            string dato = inicio.Dato; // Guarda el dato del nodo que será eliminado.
            inicio = inicio.Siguiente; // El siguiente nodo se convierte en el nuevo inicio.

            if (inicio == null) // Si después de desencolar no quedan nodos.
            {
                final = null; // También establece final como nulo.
            }

            return dato; // Retorna el dato del nodo eliminado.
        }

        // Método para ver el primer elemento sin eliminarlo.
        public string VerFrente()
        {
            if (inicio == null) // Si la cola está vacía.
            {
                return null; // Retorna null indicando que no hay elementos en la cola.
            }

            return inicio.Dato; // Retorna el dato del nodo al frente.
        }

        // Método para verificar si la cola está vacía.
        public bool EstaVacia()
        {
            return inicio == null; // Retorna true si inicio es nulo, indicando que no hay elementos.
        }

        // Método para obtener todos los elementos de la cola como una lista.
        public List<string> ObtenerElementos()
        {
            List<string> elementos = new List<string>(); // Lista para almacenar los elementos.
            Nodo actual = inicio; // Nodo temporal para recorrer la cola.
            while (actual != null) // Mientras existan nodos en la cola.
            {
                elementos.Add(actual.Dato); // Añade el dato del nodo actual a la lista.
                actual = actual.Siguiente;  // Avanza al siguiente nodo.
            }
            return elementos; // Retorna la lista de elementos.
        }

        // Método para generar una representación en formato DOT para visualización.
        public string ToDot(Nodo inicio)
        {
            StringBuilder b = new StringBuilder(); // StringBuilder para construir la representación DOT.
            Nodo actual = inicio; // Nodo temporal para recorrer la cola.
            while (actual != null) // Mientras existan nodos.
            {
                if (actual.Siguiente != null) // Si hay un nodo siguiente.
                {
                    b.AppendFormat("{0} -> {1};{2}", actual.Dato.ToString(), actual.Siguiente.Dato.ToString(), Environment.NewLine); // Agrega la relación entre nodos.
                }
                actual = actual.Siguiente; // Avanza al siguiente nodo.
            }
            return b.ToString(); // Retorna la representación en formato DOT.
        }

        // Método para obtener el nodo inicial de la cola.
        public Nodo ObtenerInicio()
        {
            return inicio; // Retorna el nodo que representa el inicio de la cola.
        }
    }
}
