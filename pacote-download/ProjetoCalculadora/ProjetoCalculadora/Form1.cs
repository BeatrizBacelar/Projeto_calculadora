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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lblMensagem.Text = "Que dia lindo!"; // exibir uma mensagem de texto ao clicar em enviar 
            lblMensagem.ForeColor= System.Drawing.Color.Blue; // mudar a cor da mensagem 
            chkCinema.Checked = true; // marcar a opção cinema

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
         //   btnEnviar.Text = "nada"; (isso é exibido no carregar da página)
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            frmCalculadora calc = new frmCalculadora(); // criando um objeto do formulário calculadora
            calc.Show(); // mostrar o formulário calculadora
        }
    }
}
