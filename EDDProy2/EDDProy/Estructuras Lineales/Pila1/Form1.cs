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

namespace Pila1 // Define el espacio de nombres para la implementación de la pila.
{
    public partial class FormLifo : Form // Clase del formulario para gestionar una pila.
    {
        Pila MiPila = new Pila(); // Instancia de la clase Pila.

        public FormLifo() // Constructor del formulario.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        // Evento para el botón "Apilar".
        private void btnApilar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text)) // Verifica que el cuadro de texto no esté vacío.
            {
                Nodo NuevoNodo = new Nodo(); // Crea un nuevo nodo.
                NuevoNodo.Dato = txtDato.Text; // Asigna el dato ingresado al nodo.
                txtDato.Clear(); // Limpia el cuadro de texto.

                MiPila.Push(NuevoNodo); // Inserta el nodo en la pila.
                MostrarPila(); // Actualiza la visualización de la pila.
            }
            else
            {
                MessageBox.Show("Ingresa un valor para apilar"); // Muestra un mensaje si el cuadro está vacío.
            }
        }

        // Método para mostrar la pila en el ListBox.
        void MostrarPila()
        {
            listPila.Items.Clear(); // Limpia los elementos actuales del ListBox.

            if (MiPila.Tope() != null) // Verifica si la pila no está vacía.
            {
                MostrarNodoEnLista(MiPila.Tope()); // Muestra los nodos de la pila recursivamente.
            }
        }

        // Método recursivo para mostrar un nodo y sus siguientes en el ListBox.
        void MostrarNodoEnLista(Nodo dato)
        {
            listPila.Items.Add(dato.Dato); // Agrega el dato del nodo al ListBox.

            if (dato.Siguiente != null) // Si el nodo tiene un siguiente.
            {
                MostrarNodoEnLista(dato.Siguiente); // Llama al método recursivamente para el siguiente nodo.
            }
        }

        // Evento para el botón "Desapilar".
        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            MiPila.Pop(); // Elimina el nodo en el tope de la pila.
            MostrarPila(); // Actualiza la visualización de la pila.
        }

        // Evento para el botón "Vaciar".
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            MiPila = new Pila(); // Reinicia la pila creando una nueva instancia vacía.
            listPila.Items.Clear(); // Limpia el ListBox.
        }

        // Evento para el botón "Graficar".
        private void btnGrafica_Click(object sender, EventArgs e)
        {
            string graphVizString; // Cadena para almacenar la representación en formato DOT.
            String strOrientacion = ""; // Configuración de orientación para el gráfico.

            Nodo tope = MiPila.Tope(); // Obtiene el nodo en el tope de la pila.
            if (tope == null) // Verifica si la pila está vacía.
            {
                MessageBox.Show("La pila está vacía"); // Muestra un mensaje si la pila está vacía.
                return;
            }

            strOrientacion = "rankdir=\"TB\";"; // Configura la orientación del gráfico como vertical (de arriba hacia abajo).
            StringBuilder sb = new StringBuilder(); // StringBuilder para construir la representación DOT.
            sb.Append("digraph G {" + strOrientacion + " node [shape=\"box\"]; " + Environment.NewLine); // Inicio del gráfico DOT.
            sb.Append(MiPila.ToDot(tope)); // Agrega la representación DOT de la pila.
            sb.Append("}"); // Cierra el gráfico DOT.
            graphVizString = sb.ToString(); // Convierte el StringBuilder a cadena.

            Bitmap bm = FileDotEngine.Run(graphVizString); // Genera un gráfico a partir de la cadena DOT.

            frmGrafica graf = new frmGrafica(); // Crea un nuevo formulario para mostrar la gráfica.
            graf.ActualizaGrafica(bm); // Actualiza la gráfica con el gráfico generado.
            graf.MdiParent = this.MdiParent; // Asigna el formulario principal como padre.
            graf.Show(); // Muestra el formulario de gráfica.
        }

        // Evento que se ejecuta al cargar el formulario (vacío en este caso).
        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}

