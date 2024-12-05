using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.FINAL // Define el espacio de nombres donde se encuentra la clase "Busqueda".
{
    internal class Busqueda // Define una clase interna llamada "Busqueda".
    {
        private const int TAMANIO = 100; // Tamaño fijo para la tabla hash.
        private int[] claves; // Arreglo para almacenar las claves.
        private string[] valores; // Arreglo para almacenar los valores correspondientes.

        public Busqueda() // Constructor de la clase.
        {
            claves = new int[TAMANIO]; // Inicializa el arreglo de claves con el tamaño definido.
            valores = new string[TAMANIO]; // Inicializa el arreglo de valores con el tamaño definido.
            for (int i = 0; i < TAMANIO; i++) // Inicializa cada posición de las claves.
            {
                claves[i] = -1; // Usa -1 como indicador de que la posición está vacía.
            }
        }

        // Función hash simple que utiliza el operador módulo para calcular el índice.
        private int FuncionHash(int clave, int tamanioTabla)
        {
            return clave % tamanioTabla; // Devuelve el índice calculado.
        }

        // Método para insertar una clave y su valor asociado en la tabla hash.
        public void Insertar(int clave, string valor)
        {
            int indice = FuncionHash(clave, TAMANIO); // Calcula el índice inicial utilizando la función hash.

            // Resuelve colisiones mediante exploración lineal.
            while (claves[indice] != -1) // Mientras la posición esté ocupada.
            {
                indice = (indice + 1) % TAMANIO; // Avanza al siguiente índice de forma circular.
            }

            claves[indice] = clave; // Almacena la clave en la posición encontrada.
            valores[indice] = valor; // Almacena el valor asociado.
        }

        // Método para buscar un valor dado su clave.
        public string Buscar(int clave)
        {
            int indice = FuncionHash(clave, TAMANIO); // Calcula el índice inicial utilizando la función hash.
            int inicio = indice; // Guarda el índice inicial para detectar un bucle.

            // Busca mientras haya una clave en la posición actual.
            while (claves[indice] != -1)
            {
                if (claves[indice] == clave) // Si la clave coincide.
                {
                    return valores[indice]; // Devuelve el valor asociado.
                }

                indice = (indice + 1) % TAMANIO; // Avanza al siguiente índice de forma circular.

                if (indice == inicio) // Si ha recorrido toda la tabla.
                {
                    break; // Detiene la búsqueda.
                }
            }
            return null; // Si no encuentra la clave, devuelve null.
        }
    }
}


