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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Botao Entrar
                private void btnEntrar_Click(object sender, EventArgs e)
                {
                    if (txtLogin.Text == "adm" && txtSenha.Text == "123")
                    {
                        Menu m = new Menu();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha inválidas!", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                }
        #endregion

        #region Botao Sair
                private void btnSair_Click(object sender, EventArgs e)
                {
                    Close();
                }
        #endregion

        #region Texto Login
                private void txtLogin_TextChanged(object sender, EventArgs e)
                {

                }

                private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if ((Keys)e.KeyChar == Keys.Enter)

                    {
                        btnEntrar_Click(sender, e);

                    }
                }
        #endregion

        #region Texto Senha
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)

            {
                btnEntrar_Click(sender, e);

            }
        }
        #endregion
    }
}
