using System;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class FormRecu : Form
    {
        public FormRecu()
        {
            InitializeComponent();
        }

        private void ShowForm<T>() where T : Form, new()
        {
            T form = new T();
            form.Show();
            this.Hide();
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            ShowForm<FormFacto>();
        }

        private void Exponent_Click(object sender, EventArgs e)
        {
            ShowForm<FormExp>();
        }

        private void SumArray_Click(object sender, EventArgs e)
        {
            ShowForm<FormArray>();
        }

        private void Fibonacci_Click(object sender, EventArgs e)
        {
            ShowForm<FormFab>();
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            ShowForm<BusqBinaria>();
        }

        private void HanoiTower_Click(object sender, EventArgs e)
        {
            ShowForm<FormHanoi>();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}