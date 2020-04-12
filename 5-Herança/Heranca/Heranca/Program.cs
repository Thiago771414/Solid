﻿using System;
using System.Collections.Generic;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ContaComum> contas = ContasDoBanco();

            foreach (ContaComum conta in contas)
            {
                conta.somaInvestimento();
                Console.WriteLine("Novo Saldo: " + conta.Saldo);
            }
            Console.ReadLine();            
        }

        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();
            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaComum(100));
            return contas;
        }

        private static ContaEstudante umaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum umaContaComum(double saldo)
        {
            ContaComum comum = new ContaComum();
            comum.Deposita(saldo);
            return comum;
        }
    }
}






