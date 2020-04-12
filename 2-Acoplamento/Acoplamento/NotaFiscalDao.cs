using System;
using System.Collections.Generic;
using System.Text;

namespace Acoplamento
{
    class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo nota");
        }
    }
}
