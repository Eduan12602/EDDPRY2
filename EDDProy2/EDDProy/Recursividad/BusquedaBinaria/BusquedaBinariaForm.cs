using System;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class BusqBinaria : Form
    {
        public BusqBinaria()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(arreglo.Text, out size))
            {
                FormItems arrayItems = new FormItems(size);
                arrayItems.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            FormRecu recursivity = new FormRecu();
            recursivity.Show();

            this.Close();
        }

        private void BusquedaBinariaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
