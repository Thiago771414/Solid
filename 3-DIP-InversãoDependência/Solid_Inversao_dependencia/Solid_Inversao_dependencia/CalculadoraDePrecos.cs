using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_Inversao_dependencia
{
    public class CalculadoraDePrecos 
    {
        private IServicoDeEntrega entrega;
        private ITabelaDePreco tabela;

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            this.entrega = entrega;
            this.tabela = tabela;
        }
        public double Calcula(Compra produto)
        {
           

            double desconto = this.tabela.DescontoPara(produto.Valor);
            double frete = this.entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
