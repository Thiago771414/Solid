using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Encapsulamento
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {

            double total = 0;

            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.AdicionaPagamento(pagamento);
                
            }
        }
    }
}
