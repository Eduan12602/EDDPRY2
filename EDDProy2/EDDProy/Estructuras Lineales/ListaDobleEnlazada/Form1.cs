using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo;

namespace ListaDobleEnlazada // Define el espacio de nombres para la implementación de la lista doblemente enlazada.
{
    public partial class FormListaDoblrEnla : Form // Clase del formulario para gestionar una lista doblemente enlazada.
    {
        private ListaDoble lista; // Instancia de la clase ListaDoble.

        public FormListaDoblrEnla() // Constructor del formulario.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            lista = new ListaDoble(); // Inicializa una lista doblemente enlazada vacía.
        }

        // Evento para el botón "Insertar al Inicio".
        private void btnInsertarInicio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int valor)) // Valida que el texto ingresado sea un número válido.
            {
                lista.InsertarInicio(valor); // Inserta el valor al inicio de la lista.
                ActualizarLista(); // Actualiza la visualización de la lista en el ListBox.
                lblMensaje.Text = "Elemento insertado al inicio."; // Muestra un mensaje de confirmación.
                txtInput.Text = ""; // Limpia el campo de texto.
            }
            else
            {
                lblMensaje.Text = "Por favor, ingresa un número válido."; // Muestra un mensaje de error.
            }
        }

        // Evento para el botón "Insertar al Final".
        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int valor)) // Valida que el texto ingresado sea un número válido.
            {
                lista.InsertarFinal(valor); // Inserta el valor al final de la lista.
                ActualizarLista(); // Actualiza la visualización de la lista en el ListBox.
                lblMensaje.Text = "Elemento insertado al final."; // Muestra un mensaje de confirmación.
                txtInput.Text = ""; // Limpia el campo de texto.
            }
            else
            {
                lblMensaje.Text = "Por favor, ingresa un número válido."; // Muestra un mensaje de error.
            }
        }

        // Evento para el botón "Borrar".
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int valor)) // Valida que el texto ingresado sea un número válido.
            {
                if (lista.Borrar(valor)) // Intenta borrar el nodo con el valor especificado.
                {
                    ActualizarLista(); // Actualiza la visualización de la lista en el ListBox.
                    lblMensaje.Text = $"Elemento {valor} borrado."; // Muestra un mensaje de confirmación.
                }
                else
                {
                    lblMensaje.Text = $"Elemento {valor} no encontrado."; // Muestra un mensaje si el elemento no fue encontrado.
                }
            }
            else
            {
                lblMensaje.Text = "Por favor, ingresa un número válido."; // Muestra un mensaje de error.
            }
        }

        // Evento para el botón "Buscar".
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int valor)) // Valida que el texto ingresado sea un número válido.
            {
                Nodo nodoEncontrado = lista.Buscar(valor); // Busca el nodo con el valor especificado.
                if (nodoEncontrado != null) // Si encuentra el nodo.
                {
                    lblMensaje.Text = $"Elemento {valor} encontrado."; // Muestra un mensaje de confirmación.
                }
                else
                {
                    lblMensaje.Text = $"Elemento {valor} no encontrado."; // Muestra un mensaje si el elemento no fue encontrado.
                }
            }
            else
            {
                lblMensaje.Text = "Por favor, ingresa un número válido."; // Muestra un mensaje de error.
            }
        }

        // Método para actualizar la lista de elementos en el ListBox.
        private void ActualizarLista()
        {
            listBoxElementos.Items.Clear(); // Limpia todos los elementos actuales del ListBox.
            foreach (var elemento in lista.ObtenerElementos()) // Recorre la lista doblemente enlazada.
            {
                listBoxElementos.Items.Add(elemento); // Agrega cada elemento al ListBox.
            }
        }

        // Evento para el botón "Graficar".
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            string graphVizString; // Cadena para almacenar la representación en formato DOT.
            String strOrientacion = ""; // Configuración de orientación para el gráfico.

            Nodo cabeza = lista.getCabeza(); // Obtiene el nodo cabeza de la lista.
            if (cabeza == null) // Verifica si la lista está vacía.
            {
                MessageBox.Show("La lista Doble está vacía"); // Muestra un mensaje si la lista está vacía.
            }
            else
            {
                strOrientacion = "rankdir=\"LR\";"; // Configura la orientación del gráfico como horizontal.
                StringBuilder sb = new StringBuilder(); // StringBuilder para construir la representación DOT.
                sb.Append("digraph G {" + strOrientacion + " node [shape=\"box\"]; " + Environment.NewLine); // Inicio del gráfico DOT.
                sb.Append(lista.ToDot(cabeza)); // Agrega la representación DOT de la lista.
                sb.Append("}"); // Cierra el gráfico DOT.
                graphVizString = sb.ToString(); // Convierte el StringBuilder a cadena.

                Bitmap bm = FileDotEngine.Run(graphVizString); // Genera un gráfico a partir de la cadena DOT.

                frmGrafica graf = new frmGrafica(); // Crea un nuevo formulario para mostrar la gráfica.
                graf.ActualizaGrafica(bm); // Actualiza la gráfica con el gráfico generado.
                graf.MdiParent = this.MdiParent; // Asigna el formulario principal como padre.
                graf.Show(); // Muestra el formulario de gráfica.
            }
        }
    }
}
