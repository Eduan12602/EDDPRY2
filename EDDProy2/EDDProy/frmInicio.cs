using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algoritmos_recursividad;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.FINAL;
using Lista_Circular_Simple;
using Pila1;

namespace EDDemo
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLifo pila = new FormLifo();
            pila.MdiParent = this;
            pila.Show();

        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbo mArboles = new frmArbo();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColaDinamica.FormFifo cola=new ColaDinamica.FormFifo();
            cola.MdiParent = this;
            cola.Show();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDobleEnlazada.FormListaDoblrEnla doble = new ListaDobleEnlazada.FormListaDoblrEnla();
            doble.MdiParent = this;
            doble.Show();
        }

        private void circularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCircula recu = new FormCircula();
            recu.MdiParent = this;
            recu.Show();

        }

        private void circularDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Circular_Doble.FormLista circularDoble = new Lista_Circular_Doble.FormLista();
            circularDoble.MdiParent = this;
            circularDoble.Show();

        }

        

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecu Recursividad = new FormRecu();
            Recursividad.MdiParent = this;
            Recursividad.Show();
        }

        private void binarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formfinal Recursividad = new Formfinal();
            Recursividad.MdiParent = this;
            Recursividad.Show();

        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusqueda frm = new frmBusqueda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void oRDENAMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formfinal Recursividad = new Formfinal();
            Recursividad.MdiParent = this;
            Recursividad.Show();
        }

        private void bUSQUEDAHASHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusqueda frm = new frmBusqueda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bUSQUEDABINARIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binario frm = new binario();
            frm.MdiParent = this;
            frm.Show();

        }

        private void iNTERCALARPRUEBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intercalar frm = new intercalar();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
