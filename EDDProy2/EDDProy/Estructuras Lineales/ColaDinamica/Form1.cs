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

namespace ColaDinamica // Define el espacio de nombres para la aplicación de la cola dinámica.
{
    public partial class FormFifo : Form // Clase que representa el formulario para manejar una cola.
    {
        private Cola cola; // Instancia de la clase Cola, que implementa la estructura FIFO.

        public FormFifo() // Constructor del formulario.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            cola = new Cola(); // Inicializa una nueva cola vacía.
        }

        // Evento para el botón Enqueue (Encolar).
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text)) // Verifica que el cuadro de texto no esté vacío.
            {
                cola.Encolar(txtInput.Text); // Encola el valor ingresado en la cola.
                txtInput.Clear(); // Limpia el cuadro de texto después de encolar.
                ActualizarLista(); // Actualiza la lista visual de elementos de la cola.
                lblPeek.Text = ""; // Limpia la etiqueta de Peek.
            }
            else
            {
                MessageBox.Show("Ingresa un valor para encolar."); // Muestra un mensaje si el cuadro de texto está vacío.
            }
        }

        // Evento para el botón Dequeue (Desencolar).
        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (!cola.EstaVacia()) // Verifica si la cola no está vacía.
            {
                cola.Desencolar(); // Elimina el primer elemento de la cola.
                ActualizarLista(); // Actualiza la lista visual de elementos de la cola.
            }
            else
            {
                MessageBox.Show("La cola está vacía."); // Muestra un mensaje si la cola está vacía.
            }
        }

        // Evento para el botón Peek (Ver Frente).
        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (!cola.EstaVacia()) // Verifica si la cola no está vacía.
            {
                lblPeek.Text = "Elemento en frente: " + cola.VerFrente(); // Muestra el elemento en el frente de la cola.
            }
            else
            {
                lblPeek.Text = "La cola está vacía."; // Muestra un mensaje si la cola está vacía.
            }
        }

        // Método para actualizar la lista de elementos en el ListBox.
        private void ActualizarLista()
        {
            listBoxCola.Items.Clear(); // Limpia todos los elementos del ListBox.
            foreach (var item in cola.ObtenerElementos()) // Itera sobre los elementos de la cola.
            {
                listBoxCola.Items.Add(item); // Agrega cada elemento al ListBox.
            }
        }

        // Evento para el botón Reset (Reiniciar Cola).
        private void button1_Click(object sender, EventArgs e)
        {
            cola = new Cola(); // Reinicia la cola creando una nueva instancia vacía.
            ActualizarLista(); // Actualiza la lista visual de elementos.
            lblPeek.Text = "La cola está vacía."; // Actualiza el texto del Peek.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este método está vacío y no realiza ninguna acción.
        }

        // Evento para el botón Graficar.
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            string graphVizString; // Cadena para almacenar la representación en formato DOT.
            String strOrientacion = ""; // Configuración de orientación para el gráfico.

            Nodo inicio = cola.ObtenerInicio(); // Obtiene el nodo inicial de la cola.
            if (inicio == null) // Verifica si la cola está vacía.
            {
                MessageBox.Show("La cola esta vacia"); // Muestra un mensaje si la cola está vacía.
                return;
            }

            strOrientacion = "rankdir=\"LR\";"; // Configura la orientación del gráfico como horizontal.
            StringBuilder sb = new StringBuilder(); // StringBuilder para construir la representación DOT.
            sb.Append("digraph G {" + strOrientacion + " node [shape=\"box\"]; " + Environment.NewLine); // Inicio del gráfico DOT.
            sb.Append(cola.ToDot(inicio)); // Agrega la representación DOT de la cola.
            sb.Append("}"); // Cierra el gráfico DOT.
            graphVizString = sb.ToString(); // Convierte el StringBuilder a cadena.

            Bitmap bm = FileDotEngine.Run(graphVizString); // Genera un gráfico a partir de la cadena DOT.

            frmGrafica graf = new frmGrafica(); // Crea un nuevo formulario para mostrar la gráfica.
            graf.ActualizaGrafica(bm); // Actualiza la gráfica con el gráfico generado.
            graf.MdiParent = this.MdiParent; // Asigna el formulario principal como padre.
            graf.Show(); // Muestra el formulario de gráfica.
        }
    


private void FormFifo_Load(object sender, EventArgs e)
        {

        }
    }
    
}
