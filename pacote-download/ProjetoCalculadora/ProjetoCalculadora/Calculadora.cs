using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumero1.Text); // pega o que foi digitado e converte para int
            int num2 = Convert.ToInt32(txtNumero2.Text);

            int soma = num1 + num2; // soma os numeros
            lblResult.Text = Convert.ToString(soma); // converte a soma para strng e joga no label lblresult

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text); // pega o que foi digitado e converte para double
            double num2 = Convert.ToDouble(txtNumero2.Text);

            double divisao = (double) num1/num2; // divide os números
            lblResult.Text = Convert.ToString(divisao); // converte a soma para string e joga no label lblresult
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // para fechar essa janela aberta e voltar para a anterior
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
