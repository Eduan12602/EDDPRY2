using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaDinamica // Define el espacio de nombres donde se encuentra la clase Nodo.
{
    internal class Nodo // Clase que representa un nodo en una estructura de datos dinámica.
    {
        public string Dato { get; set; } // Propiedad para almacenar el dato del nodo.
        public Nodo Siguiente { get; set; } // Propiedad para apuntar al siguiente nodo en la estructura.

        public Nodo(string dato) // Constructor que inicializa el nodo con un dato.
        {
            Dato = dato; // Asigna el valor proporcionado a la propiedad Dato.
            Siguiente = null; // Inicializa el enlace al siguiente nodo como nulo (sin conexión).
        }
    }
}

