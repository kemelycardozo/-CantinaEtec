using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class clsRecarga
    {
        #region Propriedades
        private int id_Recarga;
        private double valor;
        private string data;
        #endregion

        #region Setter e Getter
        public int Id_Recarga
        {
            get => id_Recarga;
            set => id_Recarga = value;
        }
        public double Valor
        {
            get => valor;
            set => valor = value;
        }
        public string Data
        {
            get => data;
            set => data = value;
        }
        #endregion

        

    }
}
