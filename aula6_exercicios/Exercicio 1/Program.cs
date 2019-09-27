using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto");
            double produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do desconto");
            double desconto = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculaDesconto(produto,desconto));  
        }

        static double CalculaDesconto ( double produto, double desconto){

            produto = produto - (produto * desconto/100);

            return produto;

        }
    }
}
