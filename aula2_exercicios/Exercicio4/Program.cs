using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco_total;

            Console.WriteLine("Digite o preço total");
            preco_total = float.Parse(Console.ReadLine());

            if ((preco_total >=100)  && (preco_total<= 1000)){
                
                preco_total= preco_total-(preco_total * 0.15f);

            }

            Console.WriteLine(preco_total);
            
        }
    }
}
