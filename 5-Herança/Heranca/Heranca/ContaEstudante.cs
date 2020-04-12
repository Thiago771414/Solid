using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class ContaEstudante : ContaComum
    {
        public int Milhas { get; private set; }

        public override void Deposita(double valor)
        {
            base.Deposita(valor);
            this.Milhas += (int)valor;
           
        }

        public override void somaInvestimento()
        {
            throw new Exception("Uma conta de estudante não possui rendimentos");
        }
    }
}
