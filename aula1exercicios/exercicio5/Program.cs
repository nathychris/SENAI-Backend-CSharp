using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float salariofixo, totaldevendas, pfinal;
            string nome;

            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu salario fixo");
            salariofixo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas");
            totaldevendas = float.Parse(Console.ReadLine());

            pfinal = salariofixo +(totaldevendas*0.10f);






        }
    }
}
