using System;
using System.Collections.Generic;

namespace Acoplamento
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviadorDeEmail enviadorDeEmail = new EnviadorDeEmail();
            NotaFiscalDao nfDao = new NotaFiscalDao();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());
            acoes.Add(new SAP());
            GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(200, "Renan Saggio");
            gnf.Gera(fatura);
            Console.ReadKey();
        }
    }
}











