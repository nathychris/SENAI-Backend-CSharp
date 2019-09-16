using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 4

            float valorreal, valordolar, valorcotação;

            Console.WriteLine("Digite o valor do real");
            valorreal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do dolar");
            valordolar = float.Parse(Console.ReadLine());   

            valorcotação = valorreal / valordolar;

            Console.WriteLine($"O valor da cotção é: {valorcotação}");



            





            
        }
    }
}
