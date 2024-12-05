using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class FormExp : Form
    {
        public FormExp()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(number.Text) || string.IsNullOrWhiteSpace(number2.Text))
                {
                    MessageBox.Show("Por favor, ingresa ambos valores.");
                    return;
                }

                // Convertir los valores a enteros
                int num = int.Parse(number.Text);
                int exp = int.Parse(number2.Text);

                // Validar que el exponente no sea negativo
                if (exp < 0)
                {
                    MessageBox.Show("El exponente no puede ser negativo.");
                    return;
                }

                // Calcular el exponente
                int result = Exponente.Run(num, exp);

                // Mostrar el resultado en el Label
                labelResult.Text = $"Resultado: {result}";
            }
            catch (OverflowException)
            {
                MessageBox.Show("El resultado es demasiado grande.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form recursivity = new FormRecu();
            recursivity.Show();
            this.Close();
        }

        private void btnstar_Click(object sender, EventArgs e)
        {
            
        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
