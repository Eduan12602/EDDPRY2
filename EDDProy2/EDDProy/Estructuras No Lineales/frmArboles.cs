using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArbo : Form
    {
        ArbolBusqueda Arbol; // Instancia de la clase ArbolBusqueda, que contiene las funciones del árbol.
        NodoBinario Raiz;    // Nodo raíz del árbol binario.

        public frmArbo()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            Arbol = new ArbolBusqueda(); // Crea un nuevo árbol.
            Raiz = null; // Inicializa la raíz como nula.
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            Arbol = null; // Reinicia el árbol.
            Raiz = null; // Limpia la raíz.
            Arbol = new ArbolBusqueda(); // Crea un nuevo árbol.
            txtArbol.Text = ""; // Limpia el texto del árbol.
            txtDato.Text = ""; // Limpia el dato de entrada.
            Arbol.strArbol = ""; // Limpia la representación en texto del árbol.

            Random rnd = new Random(); // Genera números aleatorios.
            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++) // Itera según el número de nodos.
            {
                int Dato = rnd.Next(1, 100); // Genera un número aleatorio.
                Raiz = Arbol.RegresaRaiz(); // Obtiene la raíz actual.
                Arbol.InsertaNodo(Dato, ref Raiz); // Inserta el dato en el árbol.
            }

            Arbol.MuestraArbolAcostado(1, Raiz); // Genera la representación del árbol en texto.
            txtArbol.Text = Arbol.strArbol; // Muestra el árbol en el cuadro de texto.
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Raiz = Arbol.RegresaRaiz(); // Obtiene la raíz actual.
            Arbol.strArbol = ""; // Limpia la representación en texto.
            Arbol.InsertaNodo(int.Parse(txtDato.Text), ref Raiz); // Inserta un nodo con el dato ingresado.
            Arbol.MuestraArbolAcostado(1, Raiz); // Actualiza la representación del árbol.
            txtArbol.Text = Arbol.strArbol; // Muestra el árbol actualizado.
            txtDato.Text = ""; // Limpia el cuadro de texto.
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valorBuscado;
            bool Numero = int.TryParse(txtDato.Text, out valorBuscado); // Intenta convertir el texto ingresado a un número.
            if (!Numero) // Si no es un número válido.
            {
                MessageBox.Show("Ingresa un valor numerico");
                return;
            }

            bool encontrado = Arbol.Busqueda(valorBuscado, Arbol.RegresaRaiz()); // Busca el valor en el árbol.
            if (encontrado)
                MessageBox.Show("Valor encontrado en el arbol.");
            else
                MessageBox.Show("Valor no encontrado en el arbol.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDato.Text)) // Si el cuadro de texto está vacío.
                {
                    MessageBox.Show("Por favor ingrese un valor para eliminar");
                    return;
                }

                int datoEliminar = int.Parse(txtDato.Text); // Convierte el texto a un número.
                if (Arbol.EliminarNodo(datoEliminar)) // Intenta eliminar el nodo.
                {
                    Raiz = Arbol.RegresaRaiz(); // Actualiza la raíz.
                    Arbol.strArbol = ""; // Limpia la representación en texto.
                    Arbol.MuestraArbolAcostado(1, Raiz); // Actualiza la representación del árbol.
                    txtArbol.Text = Arbol.strArbol; // Muestra el árbol actualizado.
                    MessageBox.Show($"El nodo {datoEliminar} ha sido eliminado");
                }
                else
                {
                    MessageBox.Show($"El nodo {datoEliminar} no se encontro en el arbol");
                }
                txtDato.Text = ""; // Limpia el cuadro de texto.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el nodo: {ex.Message}");
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            Raiz = Arbol.RegresaRaiz();
            Arbol.strRecorrido = "";

            // Recorrido en preorden.
            lblRecorridoPreOrden.Text = "";
            Arbol.PreOrden(Raiz);
            lblRecorridoPreOrden.Text = Arbol.strRecorrido;

            // Recorrido en inorden.
            Arbol.strRecorrido = "";
            lblRecorridoInOrden.Text = "";
            Arbol.InOrden(Raiz);
            lblRecorridoInOrden.Text = Arbol.strRecorrido;

            // Recorrido en postorden.
            Arbol.strRecorrido = "";
            lblRecorridoPostOrden.Text = "";
            Arbol.PostOrden(Raiz);
            lblRecorridoPostOrden.Text = Arbol.strRecorrido;

            // Recorrido por niveles.
            Arbol.strRecorrido = "";
            lblNiveles.Text = "";
            Arbol.RecorridoPorNiveles(Raiz);
            lblNiveles.Text = Arbol.strRecorrido;
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;
            String strOrientacion = "";

            Raiz = Arbol.RegresaRaiz(); // Obtiene la raíz.
            if (Raiz == null) // Si el árbol está vacío.
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            if (rdbtnHorizontal.Checked) // Verifica la orientación.
            {
                strOrientacion = "rankdir=\"LR\";"; // Configura la orientación horizontal.
            }

            StringBuilder b = new StringBuilder(); // Crea el gráfico en formato DOT.
            b.Append("digraph G { " + strOrientacion + "node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(Arbol.ToDot(Raiz)); // Genera la representación DOT del árbol.
            b.Append("}");

            graphVizString = b.ToString(); // Convierte el gráfico a una cadena.

            Bitmap bm = FileDotEngine.Run(graphVizString); // Genera una imagen a partir del gráfico DOT.

            frmGrafica graf = new frmGrafica(); // Abre un nuevo formulario para mostrar la gráfica.
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Arbol.PodarArbol(); // Elimina todos los nodos del árbol.
            Raiz = null; // Reinicia la raíz.
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (Arbol.EstaVacio()) // Verifica si el árbol está vacío.
            {
                MessageBox.Show("No existe arbol");
                return;
            }

            string info = $"Altura del arbol: {Arbol.ObtenerAltura()}\n" +
                          $"Cantidad de hojas: {Arbol.ContarHojas()}\n" +
                          $"Total de nodos: {Arbol.ContarNodos()}\n" +
                          $"El arbol esta completo: {Arbol.EsArbolCompleto()}\n" +
                          $"El arbol esta lleno: {Arbol.EsArbolLleno()}";

            MessageBox.Show(info, "Informacion del Arbol", MessageBoxButtons.OK, MessageBoxIcon.Information); // Muestra la información.
        }
    


private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmArbo_Load(object sender, EventArgs e)
        {

        }
    }
    
}
