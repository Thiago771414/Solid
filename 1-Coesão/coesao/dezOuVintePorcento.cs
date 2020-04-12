using System;
using System.Collections.Generic;
using System.Text;

namespace solid3
{
    public class dezOuVintePorcento : ICalculadoraDeSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.8;
            }
            else
            {
                return funcionario.SalarioBase * 0.9;
            }
        }
    }
}

