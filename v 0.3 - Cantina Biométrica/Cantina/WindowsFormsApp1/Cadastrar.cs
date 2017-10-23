using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        clsCliente objC = new clsCliente();

        public void RecuperaValores()
        {
            objC.Nome = txtNome.Text;
            objC.Endereco = txtEndereco.Text;
            objC.Complemento = txtComplemento.Text;
            objC.Datanasc = dtNasc.Text;
            objC.Cpf = txtCPF.Text;
            objC.Rg = txtRG.Text;
            objC.Bairro = txtBairro.Text;
            objC.Numero = txtNum.Text;
            objC.Cep = txtCEP.Text;
            objC.Telefone = txtTelefone.Text;
            objC.Celular = txtCelular.Text;
            objC.Funcao = cboFuncao.Text;
            objC.Cidade = cboCidade.Text;
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            RecuperaValores();
            objC.Cadastrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }

    }
}
