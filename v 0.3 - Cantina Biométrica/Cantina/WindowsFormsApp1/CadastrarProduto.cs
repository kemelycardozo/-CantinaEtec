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
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            clsCadastrarProduto objCadasProd = new clsCadastrarProduto();
            objCadasProd.Id_produto = int.Parse(txtCodProduto.Text);
            objCadasProd.Nome = txtNomeProduto.Text;
            objCadasProd.Categoria = cbmCategoriaProduto.Text;
            objCadasProd.Valor = double.Parse(txtValorProduto.Text);
            objCadasProd.Incluir();
            
        }
    }
}
