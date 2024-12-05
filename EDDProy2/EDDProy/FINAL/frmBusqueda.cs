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
                     

namespace EDDemo.FINAL               // Define el espacio de nombres del proyecto.
{
    public partial class frmBusqueda : Form  // Declara una clase que hereda de Form, representando un formulario.
    {
        private Busqueda tablaHash;          // Declara un campo privado para manejar una tabla hash.

        public frmBusqueda()                // Constructor de la clase.
        {
            InitializeComponent();          // Inicializa los componentes visuales del formulario.
            tablaHash = new Busqueda();     // Crea una instancia de la clase Busqueda (gestiona la tabla hash).
        }

        private void btnBuscar_Click(object sender, EventArgs e) // Evento asociado al botón de búsqueda.
        {
            if (int.TryParse(txtClave.Text, out int claveBuscada)) // Verifica si el texto ingresado puede convertirse a número entero.
            {
                string resultado = tablaHash.Buscar(claveBuscada); // Busca la clave en la tabla hash.

                if (resultado != null)                            // Si la clave se encuentra en la tabla.
                {
                    lblResultado.Text = $"Clave {claveBuscada} encontrada: {resultado}"; // Muestra el valor asociado.
                }
                else                                              // Si la clave no se encuentra.
                {
                    lblResultado.Text = $"Clave {claveBuscada} no encontrada."; // Muestra mensaje de clave no encontrada.
                }
            }
            else                                                  // Si el texto ingresado no es un número válido.
            {
                MessageBox.Show("Por favor, introduce un número válido."); // Muestra un mensaje de error.
            }
        }

        private void CargarDatosAleatorios()  // Método para generar y cargar datos aleatorios en la tabla hash.
        {
            Random random = new Random();    // Crea un generador de números aleatorios.
            List<string> valores = new List<string> { "Valor1", "Valor2", "Valor3", "Valor4", "Valor5", "Valor6", "Valor7", "Valor8", "Valor9", "Valor10" };
            // Lista de valores posibles para asignar a las claves.

            listBoxDatos.Items.Clear();      // Limpia el ListBox antes de cargar nuevos datos.

            for (int i = 0; i < 5; i++)     // Genera 5 pares clave-valor.
            {
                int clave = random.Next(1, 100); // Genera una clave aleatoria entre 1 y 100.
                string valor = valores[random.Next(valores.Count)]; // Selecciona un valor aleatorio de la lista.

                tablaHash.Insertar(clave, valor); // Inserta la clave y el valor en la tabla hash.

                listBoxDatos.Items.Add($"Clave: {clave}, Valor: {valor}"); // Muestra los pares en el ListBox.
            }

            MessageBox.Show("Datos aleatorios cargados correctamente."); // Mensaje de confirmación.
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e) // Evento asociado al botón de cargar archivo.
        {
            CargarDatosAleatorios();         // Llama al método para generar y cargar datos aleatorios.
        }

        private void lblResultado_Click(object sender, EventArgs e)    
        {
            
        }

        private void frmBusqueda_Load(object sender, EventArgs e)     
        {
           
        }
    }
}


