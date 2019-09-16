using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //exercicio 3
            int percentual, salariofixo, totaldevendas, pfinal;

            Console.WriteLine("Digite seu percentual da comissão");
            percentual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu salario fixo");
            salariofixo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas");
            totaldevendas = int.Parse(Console.ReadLine());

            pfinal = salariofixo + totaldevendas * (percentual/100);

            Console.WriteLine($"O vendedor irá receber: {pfinal}");


















        }
    }
}
