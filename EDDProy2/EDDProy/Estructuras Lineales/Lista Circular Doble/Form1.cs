using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Circular_Doble // Define el espacio de nombres para las clases relacionadas con la lista circular doble.
{
    public partial class FormLista : Form // Clase del formulario para manejar la lista circular doble.
    {
        private ListaCircularDoble listaCircularDoble = new ListaCircularDoble(); // Instancia de la lista circular doble.

        public FormLista() // Constructor del formulario.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        // Evento para el botón Insertar.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int posicion, dato;

            // Verifica si los valores ingresados son numéricos válidos.
            if (int.TryParse(txtPosicion.Text.Trim(), out posicion) && int.TryParse(txtDato.Text.Trim(), out dato))
            {
                listaCircularDoble.Insertar(posicion, dato); // Llama al método Insertar de la lista circular doble.

                ActualizarLista(); // Actualiza la visualización de la lista en el ListBox.
            }
            else
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos."); // Muestra un mensaje si los valores no son válidos.
            }
        }

        // Evento para el botón Eliminar.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion;

            // Verifica si el valor de posición ingresado es numérico válido.
            if (int.TryParse(txtPosicion.Text.Trim(), out posicion))
            {
                int eliminado = listaCircularDoble.Eliminar(posicion); // Llama al método Eliminar de la lista circular doble.

                if (eliminado != 0) // Si se eliminó un nodo válido.
                {
                    MessageBox.Show($"Elemento eliminado: {eliminado}"); // Muestra un mensaje con el dato eliminado.
                    ActualizarLista(); // Actualiza la visualización de la lista en el ListBox.
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, posición inválida."); // Muestra un mensaje si no se pudo eliminar.
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido."); // Muestra un mensaje si la posición no es válida.
            }
        }

        // Método para actualizar la lista de elementos en el ListBox.
        private void ActualizarLista()
        {
            listBoxDatos.Items.Clear(); // Limpia los elementos actuales del ListBox.

            Nodo actual = listaCircularDoble.Inicio; // Obtiene el nodo inicial de la lista.

            if (actual != null) // Verifica si la lista no está vacía.
            {
                do
                {
                    listBoxDatos.Items.Add(actual.Dato); // Agrega el dato del nodo actual al ListBox.
                    actual = actual.Sig; // Avanza al siguiente nodo.
                } while (actual != listaCircularDoble.Inicio); // Recorre la lista hasta volver al nodo inicial.
            }
        }

        // Evento para el botón Reiniciar (limpiar la lista).
        private void button1_Click(object sender, EventArgs e)
        {
            listaCircularDoble = new ListaCircularDoble(); // Reinicia la lista creando una nueva instancia.
            listBoxDatos.Items.Clear(); // Limpia el contenido del ListBox.
        }

        // Evento que se ejecuta cuando el formulario se carga (sin implementación).
        private void FormLista_Load(object sender, EventArgs e)
        {
            // Este método está vacío y no realiza ninguna acción específica.
        }
    }
}

