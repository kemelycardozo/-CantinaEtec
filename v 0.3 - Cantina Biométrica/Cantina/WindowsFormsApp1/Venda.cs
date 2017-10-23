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
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
            AutoCompleteText();
        }

      

        private void btnVolta_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Close();
            
        }

        public void AutoCompleteText()
        {
            txtProduto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            if (t != null)
            {
                //say you want to do a search when user types 3 or more chars
                if (t.Text.Length >= 3)
                {
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    new clsVenda().EncontrarProdutosPorNome(t.Text).ForEach(p => collection.Add(p.Nome));

                    this.txtProduto.AutoCompleteCustomSource = collection;
                }
            }
        }
    }
}
