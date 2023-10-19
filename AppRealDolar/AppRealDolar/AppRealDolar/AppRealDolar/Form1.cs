using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRealDolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConvertToDollar_Click(object sender, EventArgs e)
        {
            // Verify if all the if all the fields are filled
            if (string.IsNullOrWhiteSpace(txtValoremReal.Text) || string.IsNullOrWhiteSpace(txtCotacaoDolar.Text))
            {
                MessageBox.Show("Por favor, insira valores em todos as caixas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Converts the values from text to double
            double valorDolar = Convert.ToDouble(txtValoremReal.Text)
                / Convert.ToDouble(txtCotacaoDolar.Text);
            lblValorDollar.Text = "Valor em U$: " + valorDolar.ToString("N2");

            // Shows the result
            lblValorDollar.Text = "Valor em U$: " + valorDolar.ToString("N2");
            txtValoremReal.Clear();
            txtValoremReal.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
