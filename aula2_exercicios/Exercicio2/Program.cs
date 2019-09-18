using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco_total;
            
            Console.WriteLine("Digite seu preço");
            preco_total = float.Parse(Console.ReadLine());

            if(preco_total > 100){
                
                preco_total = preco_total - 25;

            }

            Console.WriteLine(preco_total);

        }
    }
}
