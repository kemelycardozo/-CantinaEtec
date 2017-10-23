using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class clsProduto
    {
        #region Propriedades
        private int id_produto;
        private string nome, categoria;
        private double valor;
        #endregion

        #region Getter e Setter
        public int Id_produto
        {
            get => id_produto;
            set => id_produto = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Categoria
        {
            get => categoria;
            set => categoria = value;
        }
        public double Valor
        {
            get => valor;
            set => valor = value;
        }
#endregion
    }
}
