using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo;
using Lista_Circular_SImple;

namespace Lista_Circular_Simple // Define el espacio de nombres para la implementación de la lista circular simple.
{
    public partial class FormCircula : Form // Clase que representa el formulario para manejar una lista circular simple.
    {
        private ListaCircular listaCircular = new ListaCircular(); // Instancia de la clase ListaCircular.

        public FormCircula() // Constructor del formulario.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        // Evento para el botón Insertar.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int posicion, dato;

            // Valida si los valores ingresados en los TextBoxes son números válidos.
            if (int.TryParse(txtPosicion.Text, out posicion) && int.TryParse(txtDato.Text, out dato))
            {
                listaCircular.Insertar(posicion, dato); // Llama al método Insertar de la lista circular simple.

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

            // Valida si el valor ingresado en el TextBox de posición es un número válido.
            if (int.TryParse(txtPosicion.Text, out posicion))
            {
                int eliminado = listaCircular.Eliminar(posicion); // Llama al método Eliminar de la lista circular simple.

                if (eliminado != 0) // Si se eliminó un nodo válido.
                {
                    MessageBox.Show($"Elemento eliminado: {eliminado}"); // Muestra el valor eliminado.
                    ActualizarLista(); // Actualiza la visualización de la lista en el ListBox.
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, posición inválida"); // Muestra un mensaje si no se pudo eliminar.
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido."); // Muestra un mensaje si la posición no es válida.
            }
        }

        // Método para actualizar el contenido del ListBox con los elementos actuales de la lista circular.
        private void ActualizarLista()
        {
            listBoxDatos.Items.Clear(); // Limpia los elementos actuales del ListBox.

            Nodo actual = listaCircular.Inicio; // Obtiene el nodo inicial de la lista.

            if (actual != null) // Verifica si la lista no está vacía.
            {
                do
                {
                    listBoxDatos.Items.Add(actual.Dato); // Agrega el dato del nodo actual al ListBox.
                    actual = actual.Sig; // Avanza al siguiente nodo.
                } while (actual != listaCircular.Inicio); // Recorre la lista hasta volver al nodo inicial.
            }
        }

        private void listBoxDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

