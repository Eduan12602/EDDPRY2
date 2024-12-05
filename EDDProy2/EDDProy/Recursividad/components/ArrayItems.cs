using System;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class FormItems : Form
    {

        private int[] array;
        private int currentIndex;
        public FormItems(int size)
        {
            InitializeComponent();
            array = new int[size];
            currentIndex = 0;
        }

        private void AddElement_Click(object sender, EventArgs e)
        {
            int element;
            if (int.TryParse(number.Text, out element))
            {
                array[currentIndex] = element;
                currentIndex++;

                if (currentIndex < array.Length)
                {
                    number.Text = string.Empty;
                    number.Focus();
                }
                else
                {
                    Binaria search = new Binaria(array);
                    this.Hide();
                    search.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            BusqBinaria binary = new BusqBinaria();
            binary.Show();

            this.Close();
        }
    }
}
