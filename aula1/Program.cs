using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somente Declaramos, sem atribuir valor 
            int num1;

            //Declaramos atribuindo valor
            int num2 = 5;

            //Desclaramos diversas variaveis do mesmo tipo 
            int num3, num4, num5;

            //Variavel do tipo decimal (real)
            float media;

            //Variavel do tipo logico (booleana)
            bool resultado = false;

            //Variavel do tipo texto (caracteres)
            string nomeAluno;

            //Quebra de linha
            Console.WriteLine();

            //Escreve em uma linha quebrando-a
            Console.WriteLine("Bem Vindo a nossa primeira aplicação!");

            //Continua escrevendo a mesma linha
            Console.Write(" Digite ");
            Console.Write(" Seu Nome: ");

            //Capturo o dado digitado pelo usuario e salvo na variavel
            nomeAluno = Console.ReadLine();

            //Concatenação
            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota:");

            //Converto o texto capturando para o tipo inteiro
            num3 =  int.Parse(Console.ReadLine());
            
            //Interpolação
            Console.WriteLine($"Sua primeira nota é {num3}");
            

            Console.WriteLine("Digite sua segunda nota:");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota");
            num5 = int.Parse(Console.ReadLine());

            media = (num3 + num4 + num5)/3;

            Console.WriteLine("Sua media é " + media);



















            
        }
    }
}
