using System;

namespace Solid_Inversao_dependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra("SAO PAULO", 500);
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Frete());

            double resultado = calc.Calcula(compra);

            Console.WriteLine("O preço da compra é : " + resultado);
            Console.ReadKey();
        }
    }
}






