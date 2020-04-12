using System;

namespace solid3
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new dezOuVintePorcento()), 2000);
            double resultado;

            resultado = cs.Calcula(funcionario);

            Console.WriteLine("O salario de um Desenvolvedor que ganha 2000 bruto é : " + resultado);
            Console.ReadKey();
        }
    }
}
