using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           
           string [] produto = new string[12];
           string [] cor = new string[12];
           double [] tamanho = new double [12];
           double [] preco = new double [12];

           for( int i=0; i<=11; i++){

               Console.WriteLine("Digite o nome do produto");
               produto[i] = Console.ReadLine();

               Console.WriteLine("Digite a cor");
               cor[i] = Console.ReadLine();

               Console.WriteLine("Digite o tamanho");
               tamanho[i] = double.Parse(Console.ReadLine());

               Console.WriteLine("Digite o preço");
               preco[i] = double.Parse(Console.ReadLine());
           }

           for(int i=0; i<=11; i++){

               Console.WriteLine($"Nome do produto{produto}");
               Console.WriteLine($"Cor{cor}");
               Console.WriteLine($"Tamanho{tamanho}");
               Console.WriteLine($"Preço{preco}");
           }
        }
    }
}
