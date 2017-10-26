using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace WindowsFormsApp1
{
    public class clsVenda
    {
        #region Propriedades
        private int id_Venda;
        private double valor;
        private string produto;
        private DateTime data;
        #endregion

        #region Getter e Setter
        public int Id_Venda
        {
            get => id_Venda;
            set => id_Venda = value;
        }
        public double Valor
        {
            get => valor;
            set => valor = value;
        }
        public DateTime Data
        {
            get => data;
            set => data = value;
        }
        public string Produto { get => produto; set => produto = value; }
        #endregion

        Dados objDados = new Dados();

        public List<clsProduto> EncontrarProdutosPorNome(string nome)
        {
            var dados = new Dados();
            
            var table = dados.ConvertSqlToDataTable("select * from produto where nome like @nome", 
                                                    new MySqlParameter("nome", string.Format("{0}%", nome)));

            var result = new List<clsProduto>();

            foreach(DataRow row in table.Rows)
            {
                result.Add(new clsProduto()
                {
                    Id_produto = int.Parse(row["id_produto"].ToString()),
                    Nome = row["nome"].ToString(),
                    Valor = double.Parse(row["valor"].ToString()) 
                });
            }

            return result;
        }

        //public DataTable BuscaCodigo()
        //{

        //    DataTable tblRecuperada = objDados.ConvertSqlToDataTable(
        //        "SELECT * FROM Produto WHERE Nome = @Nome",
        //        new MySqlParameter("@Nome", Produto));

        //    return tblRecuperada;
        //}



    }
}
