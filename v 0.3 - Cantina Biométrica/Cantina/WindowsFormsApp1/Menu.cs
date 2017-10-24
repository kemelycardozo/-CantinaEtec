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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar c = new Cadastrar();
            c.Show();
            Close();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.Show();
            
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            Recarregar r = new Recarregar();
            r.Show();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            Saldo s = new Saldo();
            s.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastrarProduto cp = new CadastrarProduto();
            cp.Show();
        }
    }
}
