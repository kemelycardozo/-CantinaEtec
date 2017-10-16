using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class clsCliente
    {
        Dados objDados = new Dados();

        #region Atributos da Tabela Cliente

        private string cep, rg, cpf, telefone, celular, numero, datanasc, endereco, bairro, nome, cidade, complemento, funcao;

        public string Cep { get => cep; set => cep = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Datanasc { get => datanasc; set => datanasc = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Funcao { get => funcao; set => funcao = value; }



        #endregion


        public void Cadastrar()
        {
            try
            {

                objDados.ConvertSqlToInt(@"INSERT Cliente  
                    (cpf, rg, nome, datanasc, endereco, numero, bairro, complemento, cidade, cep, telefone, celular, funcao) 
                    VALUES(@cpf, @rg, @nome, @datanasc, @endereco, @numero, @bairro, @complemento, @cidade, @cep, @telefone, @celular, @funcao)",
                    new MySqlParameter("@cpf", Cpf),
                    new MySqlParameter("@rg", Rg),
                    new MySqlParameter("@nome", Nome),
                    new MySqlParameter("@datanasc", Datanasc),
                    new MySqlParameter("@endereco", Endereco),
                    new MySqlParameter("@numero", Numero),
                    new MySqlParameter("@bairro", Bairro),
                    new MySqlParameter("@complemento", Complemento),
                    new MySqlParameter("@cidade", Cidade),
                    new MySqlParameter("@cep", Cep),
                    new MySqlParameter("@telefone", Telefone),
                    new MySqlParameter("@celular", Celular),
                    new MySqlParameter("@funcao", Funcao )
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
