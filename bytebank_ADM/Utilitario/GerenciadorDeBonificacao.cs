using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            totalBonificacao += funcionario.getBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return totalBonificacao;
        }

    }
}
