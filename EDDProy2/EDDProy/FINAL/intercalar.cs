using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.FINAL // Define el espacio de nombres donde está la clase.
{
    public partial class intercalar : Form // Define una clase llamada "intercalar" que hereda de Form, representando un formulario.
    {
        private List<int> lista1; // Declara una lista para almacenar los números de la primera lista.
        private List<int> lista2; // Declara una lista para almacenar los números de la segunda lista.

        public intercalar() // Constructor de la clase.
        {
            InitializeComponent(); // Inicializa los componentes visuales del formulario.
            lista1 = new List<int>(); // Inicializa la lista1 como una lista vacía.
            lista2 = new List<int>(); // Inicializa la lista2 como una lista vacía.
        }

        // Método para generar listas aleatorias y ordenarlas.
        private void GenerarListas()
        {
            Random random = new Random(); // Crea un generador de números aleatorios.
            lista1.Clear(); // Limpia la lista1 antes de agregar nuevos números.
            lista2.Clear(); // Limpia la lista2 antes de agregar nuevos números.

            // Genera 5 números aleatorios para cada lista.
            for (int i = 0; i < 5; i++)
            {
                lista1.Add(random.Next(1, 50)); // Agrega un número aleatorio entre 1 y 50 a lista1.
                lista2.Add(random.Next(1, 50)); // Agrega un número aleatorio entre 1 y 50 a lista2.
            }

            lista1.Sort(); // Ordena lista1 en orden ascendente.
            lista2.Sort(); // Ordena lista2 en orden ascendente.

            // Mostrar las listas en ListBoxes del formulario.
            listBoxLista1.Items.Clear(); // Limpia el ListBox de lista1 antes de mostrar los nuevos datos.
            listBoxLista2.Items.Clear(); // Limpia el ListBox de lista2 antes de mostrar los nuevos datos.

            // Agrega cada número de lista1 al ListBox correspondiente.
            foreach (var num in lista1)
            {
                listBoxLista1.Items.Add(num); // Muestra cada número de lista1 en el ListBox.
            }

            // Agrega cada número de lista2 al ListBox correspondiente.
            foreach (var num in lista2)
            {
                listBoxLista2.Items.Add(num); // Muestra cada número de lista2 en el ListBox.
            }

            MessageBox.Show("Listas generadas y ordenadas."); // Muestra un mensaje indicando que las listas están listas.
        }

        // Método para intercalar dos listas ordenadas.
        private List<int> Intercalar(List<int> lista1, List<int> lista2)
        {
            List<int> resultado = new List<int>(); // Declara una lista para almacenar los resultados intercalados.
            int i = 0, j = 0; // Inicializa índices para recorrer ambas listas.

            // Mientras haya elementos en ambas listas.
            while (i < lista1.Count && j < lista2.Count)
            {
                if (lista1[i] <= lista2[j]) // Si el elemento actual de lista1 es menor o igual al de lista2.
                {
                    resultado.Add(lista1[i]); // Agrega el elemento de lista1 al resultado.
                    i++; // Avanza al siguiente elemento de lista1.
                }
                else // Si el elemento actual de lista2 es menor.
                {
                    resultado.Add(lista2[j]); // Agrega el elemento de lista2 al resultado.
                    j++; // Avanza al siguiente elemento de lista2.
                }
            }

            // Agregar los elementos restantes de lista1 (si quedan).
            while (i < lista1.Count)
            {
                resultado.Add(lista1[i]); // Agrega el elemento actual de lista1 al resultado.
                i++; // Avanza al siguiente elemento de lista1.
            }

            // Agregar los elementos restantes de lista2 (si quedan).
            while (j < lista2.Count)
            {
                resultado.Add(lista2[j]); // Agrega el elemento actual de lista2 al resultado.
                j++; // Avanza al siguiente elemento de lista2.
            }

            return resultado; // Devuelve la lista intercalada.
        }

        private void btnIntercalar_Click(object sender, EventArgs e) // Evento asociado al clic del botón "Intercalar".
        {
            List<int> resultado = Intercalar(lista1, lista2); // Llama al método para intercalar lista1 y lista2.

            listBoxResultado.Items.Clear(); // Limpia el ListBox de resultados antes de mostrar los nuevos datos.
            foreach (var num in resultado) // Recorre la lista intercalada.
            {
                listBoxResultado.Items.Add(num); // Muestra cada número intercalado en el ListBox de resultados.
            }

            MessageBox.Show("Listas intercaladas correctamente."); // Muestra un mensaje indicando que la operación fue exitosa.
        }

        private void btnGenerar_Click(object sender, EventArgs e) // Evento asociado al clic del botón "Generar".
        {
            GenerarListas(); // Llama al método para generar y mostrar las listas.
        }
    }
}

