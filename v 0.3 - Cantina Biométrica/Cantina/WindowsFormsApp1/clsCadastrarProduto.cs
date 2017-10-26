using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public class clsCadastrarProduto
    {
        private string nome;
        private string categoria;
        private double valor;

        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public double Valor { get => valor; set => valor = value; }

        Dados objDados = new Dados();

        public void Incluir() {
            try
            {
                objDados.ConvertSqlToInt(@"INSERT Produto  
                    (nome, categoria, valor) 
                    VALUES(@nome, @categoria, @valor)",
                new MySqlParameter("@nome", nome),
                new MySqlParameter("@categoria", categoria),
                new MySqlParameter("@valor", valor)

             );

                MessageBox.Show("Cadastro realizada!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro!");
            }
        }
    }
}


