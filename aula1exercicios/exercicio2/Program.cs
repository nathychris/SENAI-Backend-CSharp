using System;

namespace aula1exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            
        //Exercicio 2
        float pcusto, percentual, pfinal;

        Console.WriteLine("Digite o Preço de Custo da Mercadoria");
        pcusto =  float.Parse(Console.ReadLine());

        Console.WriteLine("Digite percentual de acréscimo");
        percentual = float.Parse(Console.ReadLine());

        pfinal = pcusto+((percentual/100)*pcusto);

        Console.WriteLine($"O preço final é: {pfinal}");


    
      
        
       
       

       















        }
    }
}
