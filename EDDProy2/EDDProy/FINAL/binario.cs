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

namespace EDDemo.FINAL  // Define el espacio de nombres del proyecto.
{
    public partial class binario : Form  // Declara una clase que hereda de Form, representando un formulario.
    {
        private List<int> numeros;  // Lista para almacenar los números generados.

        public binario()  // Constructor de la clase.
        {
            InitializeComponent();  // Inicializa los componentes visuales del formulario.
            numeros = new List<int>();  // Inicializa la lista de números.
        }

        // Método para generar un arreglo de números aleatorios.
        private void GenerarArreglo()
        {
            Random random = new Random();  // Crea un generador de números aleatorios.
            numeros.Clear();  // Limpia la lista antes de agregar nuevos números.
            listBoxNumeros.Items.Clear();  // Limpia el ListBox.

            // Genera 10 números aleatorios entre 1 y 100.
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(1, 100);  // Genera un número aleatorio entre 1 y 100.
                numeros.Add(numero);  // Agrega el número a la lista.
                listBoxNumeros.Items.Add(numero);  // Muestra el número en el ListBox.
            }

            numeros.Sort();  // Ordena la lista de números.
            MessageBox.Show("Arreglo generado y ordenado.");  // Muestra un mensaje indicando que el arreglo se ha generado y ordenado.
        }

        // Método para realizar la búsqueda binaria.
        private int BuscarBinaria(int target)
        {
            int low = 0;  // Índice inferior.
            int high = numeros.Count - 1;  // Índice superior.

            while (low <= high)  // Mientras los índices no se crucen.
            {
                int mid = (low + high) / 2;  // Calcula el índice medio.
                if (numeros[mid] == target)  // Si el número medio es el buscado.
                {
                    return mid;  // Devuelve la posición del número.
                }
                else if (numeros[mid] < target)  // Si el número medio es menor que el buscado.
                {
                    low = mid + 1;  // Ajusta el índice inferior.
                }
                else  // Si el número medio es mayor que el buscado.
                {
                    high = mid - 1;  // Ajusta el índice superior.
                }
            }

            return -1;  // Si no se encuentra el número, devuelve -1.
        }

        private void btnBuscar_Click(object sender, EventArgs e)  // Evento asociado al botón de búsqueda.
        {
            if (int.TryParse(txtBuscar.Text, out int numeroBuscado))  // Verifica si el texto ingresado es un número válido.
            {
                int resultado = BuscarBinaria(numeroBuscado);  // Llama al método de búsqueda binaria.

                if (resultado != -1)  // Si el número fue encontrado.
                {
                    lblResultado.Text = $"Número {numeroBuscado} encontrado en la posición {resultado}.";  // Muestra el resultado.
                }
                else  // Si el número no fue encontrado.
                {
                    lblResultado.Text = $"Número {numeroBuscado} no encontrado.";  // Muestra un mensaje indicando que no se encontró.
                }
            }
            else  // Si el texto ingresado no es válido.
            {
                MessageBox.Show("Por favor, ingresa un número válido.");  // Muestra un mensaje de error.
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)  // Evento asociado al botón de generar arreglo.
        {
            GenerarArreglo();  // Llama al método para generar y ordenar el arreglo.
        }

        private void btnOrdenar_Click(object sender, EventArgs e)  // Evento asociado al botón de ordenar.
        {
            Stopwatch stopwatch = new Stopwatch();  // Crea una instancia de Stopwatch para medir el tiempo.
            stopwatch.Start();  // Inicia la medición del tiempo.

            numeros.Sort();  // Ordena la lista de números.

            stopwatch.Stop();  // Detiene la medición del tiempo.

            listBoxNumeros.Items.Clear();  // Limpia el ListBox antes de mostrar los números ordenados.

            foreach (var numero in numeros)  // Recorre los números ordenados.
            {
                listBoxNumeros.Items.Add(numero);  // Los muestra en el ListBox.
            }

            lblResultado.Text = $"Números ordenados en {stopwatch.ElapsedMilliseconds} milisegundos.";  // Muestra el tiempo de ordenación.
        }
    }
}

