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
    public partial class Recarregar : Form
    {
        public Recarregar()
        {
            InitializeComponent();
        }

        clsRecarga ObjRecarga = new clsRecarga();

        private void btnVolta_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            ObjRecarga.Valor = double.Parse(txtValorRecarga.Text);
            ObjRecarga.Data = dtRecarga.Text;
        }

    }
}
