using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class clsVenda
    {
        #region Propriedades
        private int id_Venda;
        private double valor;
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
#endregion

    }
}
