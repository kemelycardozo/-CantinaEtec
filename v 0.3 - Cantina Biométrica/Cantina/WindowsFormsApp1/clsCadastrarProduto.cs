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
        private int id_produto;
        private string nome;
        private string categoria;
        private double valor;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public double Valor { get => valor; set => valor = value; }

        Dados objDados = new Dados();

        public void Incluir() {
            try
            {
                objDados.ConvertSqlToInt(@"INSERT Produto  
                    (id_produto, nome, categoria, valor) 
                    VALUES(@id_produto, @nome, @categoria, @valor)",
                new MySqlParameter("@id_produto", id_produto),
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


