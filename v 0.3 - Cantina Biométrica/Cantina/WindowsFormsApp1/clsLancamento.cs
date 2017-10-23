using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public class clsLancamento
    {
        #region Propriedades
        private int id_lancamento;
        private double valor;
        private DateTime data;
        #endregion

        #region Getter e Setter
        public int Id_lancamento
        {
            get => id_lancamento;
            set => id_lancamento = value;
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

        clsRecarga ObjRec = new clsRecarga();
        clsVenda ObjV = new clsVenda();
        clsSaldo ObjS = new clsSaldo();

        public double Lancar(double opcao)
        {
            if (opcao == ObjV.Valor)
            {
                if (ObjS.Valor< ObjV.Valor)
                {
                    MessageBox.Show("Você não tem saldo para Debitar");
                }
                else
                {
                    ObjS.Valor = ObjS.Valor - ObjV.Valor;
                }
            }else
            {
                ObjS.Valor = ObjS.Valor + ObjRec.Valor; 
            }
            return 0;
        }

    }
}
