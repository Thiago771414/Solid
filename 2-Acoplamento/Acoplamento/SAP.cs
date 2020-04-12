using System;
using System.Collections.Generic;
using System.Text;

namespace Acoplamento
{
    class SAP : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando nota para SAP");
        }
    }
}
