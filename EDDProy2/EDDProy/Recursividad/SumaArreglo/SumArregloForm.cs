using System;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class FormArray : Form
    {
        public FormArray()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(arreglo.Text, out size))
            {
                FormElem arrayElements = new FormElem(size);
                arrayElements.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormRecu recursivity = new FormRecu();
            recursivity.Show();

            this.Close();
        }
    }
}
