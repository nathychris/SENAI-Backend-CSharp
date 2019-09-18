using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario,  despesatotal;
            

            Console.WriteLine("Digite seu salario");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua despesa");
            despesatotal = float.Parse(Console.ReadLine());

            if ( salario > despesatotal){
                
                Console.WriteLine("Saldo final positivo");

            }else{
                
                Console.WriteLine("Saldo final negativo");
                
            }

              
        }
    }
}
