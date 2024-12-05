using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.FINAL
{
    public partial class Formfinal : Form
    {
        // Declaración de variables
        int[] numeros;  // Declaración del arreglo de números 

        public Formfinal()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            if (TryParseNumeros(txtNumeros.Text, out numeros)) // Convierte el texto ingresado a un arreglo de enteros.
            {
                Stopwatch stopwatch = new Stopwatch(); // Instancia para medir tiempo de ejecución.
                stopwatch.Start(); // Inicia la medición.

                Ordenacion.Burbuja(numeros); // Llama al método de ordenación Burbuja.

                stopwatch.Stop(); // Detiene la medición.
                MessageBox.Show($"Números ordenados: {string.Join(", ", numeros)}\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} milisegundos."); // Muestra los números ordenados y el tiempo.
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos."); // Muestra un mensaje de error si el texto no es válido.
            }
        }



        private void btnOrdenarQuickSort_Click(object sender, EventArgs e)
        {
            if (TryParseNumeros(txtNumeros.Text, out numeros)) // Convierte el texto ingresado a un arreglo de enteros.
            {
                Stopwatch stopwatch = new Stopwatch(); // Instancia para medir tiempo de ejecución.
                stopwatch.Start(); // Inicia la medición.

                Ordenacion.QuickSort(numeros, 0, numeros.Length - 1); // Llama al método de QuickSort.

                stopwatch.Stop(); // Detiene la medición.
                MessageBox.Show($"Números ordenados (QuickSort): {string.Join(", ", numeros)}\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} milisegundos."); // Muestra el resultado.
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos."); // Muestra un mensaje de error si el texto no es válido.
            }
        }



        private void btnOrdenarShellSort_Click(object sender, EventArgs e)
        {
            if (TryParseNumeros(txtNumeros.Text, out numeros)) // Convierte el texto ingresado a un arreglo de enteros.
            {
                Stopwatch stopwatch = new Stopwatch(); // Instancia para medir tiempo de ejecución.
                stopwatch.Start(); // Inicia la medición.

                Ordenacion.ShellSort(numeros); // Llama al método ShellSort.

                stopwatch.Stop(); // Detiene la medición.
                MessageBox.Show($"Números ordenados (ShellSort): {string.Join(", ", numeros)}\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} milisegundos."); // Muestra el resultado.
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos."); // Muestra un mensaje de error si el texto no es válido.
            }
        }

        private void btnOrdenarRadixSort_Click(object sender, EventArgs e)
        {
            if (TryParseNumeros(txtNumeros.Text, out numeros)) // Convierte el texto ingresado a un arreglo de enteros.
            {
                Stopwatch stopwatch = new Stopwatch(); // Instancia para medir tiempo de ejecución.
                stopwatch.Start(); // Inicia la medición.

                Ordenacion.RadixSort(numeros); // Llama al método RadixSort.

                stopwatch.Stop(); // Detiene la medición.
                MessageBox.Show($"Números ordenados (RadixSort): {string.Join(", ", numeros)}\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} milisegundos."); // Muestra el resultado.
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos."); // Muestra un mensaje de error si el texto no es válido.
            }
        }



        private void btnIntercalar_Click(object sender, EventArgs e)
        {
            int[] arr1 = { 1, 3, 5, 7 }; // Primer arreglo ordenado.
            int[] arr2 = { 2, 4, 6, 8 }; // Segundo arreglo ordenado.

            Stopwatch stopwatch = new Stopwatch(); // Instancia para medir tiempo de ejecución.
            stopwatch.Start(); // Inicia la medición.

            int[] resultado = Ordenacion.Intercalar(arr1, arr2); // Llama al método de intercalación.

            stopwatch.Stop(); // Detiene la medición.
            MessageBox.Show($"Arreglo intercalado: {string.Join(", ", resultado)}\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} milisegundos."); // Muestra el resultado intercalado y el tiempo.
        }
        


        private void btnOrdenarMezclaDirecta_Click(object sender, EventArgs e)
        {
            if (TryParseNumeros(txtNumeros.Text, out numeros)) // Convierte el texto ingresado a un arreglo de enteros.
            {
                Stopwatch stopwatch = new Stopwatch(); // Instancia para medir tiempo de ejecución.
                stopwatch.Start(); // Inicia la medición.

                Ordenacion.MezclaDirecta(numeros); // Llama al método de mezcla directa.

                stopwatch.Stop(); // Detiene la medición.
                MessageBox.Show($"Números ordenados (Mezcla Directa): {string.Join(", ", numeros)}\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} milisegundos."); // Muestra el resultado.
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos."); // Muestra un mensaje de error si el texto no es válido.
            }
        }

        private void btnOrdenarMezclaNatural_Click(object sender, EventArgs e)
        {
            if (TryParseNumeros(txtNumeros.Text, out numeros)) // Convierte el texto ingresado a un arreglo de enteros.
            {
                Stopwatch stopwatch = new Stopwatch(); // Instancia para medir tiempo de ejecución.
                stopwatch.Start(); // Inicia la medición.

                Ordenacion.MergeSortNatural(numeros); // Llama al método de mezcla natural.

                stopwatch.Stop(); // Detiene la medición.
                MessageBox.Show($"Números ordenados (Mezcla Natural): {string.Join(", ", numeros)}\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} milisegundos."); // Muestra el resultado.
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos."); // Muestra un mensaje de error si el texto no es válido.
            }
        }

        private void Formfinal_Load(object sender, EventArgs e)
        {

        }


        // Método para intentar convertir el texto del TextBox en un arreglo de enteros
        private bool TryParseNumeros(string input, out int[] result)
        {
            string[] partes = input.Split(','); // Divide el texto por comas.
            List<int> numerosList = new List<int>(); // Lista temporal para almacenar los números.

            foreach (string parte in partes) // Recorre cada parte del texto.
            {
                if (int.TryParse(parte.Trim(), out int num)) // Intenta convertir la parte a entero.
                {
                    numerosList.Add(num); // Agrega el número convertido a la lista.
                }
                else
                {
                    result = null; // Si falla la conversión, retorna null.
                    return false; // Devuelve false indicando que hubo un error.
                }
            }

            result = numerosList.ToArray(); // Convierte la lista a un arreglo.
            return true; // Devuelve true si todos los números son válidos.
        }

    }
    
}
