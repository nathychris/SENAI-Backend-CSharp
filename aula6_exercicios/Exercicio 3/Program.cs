using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MostraInfo();

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            Console.WriteLine(MostraInfo(nome, sobrenome));


            
            Console.WriteLine("Digite sua idade");
            string idade = (Console.ReadLine());

            Console.WriteLine("Digite seu peso");
            string peso = (Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            string altura = (Console.ReadLine());
            Console.WriteLine(MostraInfo(idade, peso, altura));

            
        }

        static void MostraInfo (){
            Console.WriteLine("Serviço Nacional de Aprendizagem Industrial");
        } 

        static string MostraInfo(  string nome , string sobrenome){
            return nome + sobrenome;

        }

        static string MostraInfo( string idade , string peso, string altura){

           return idade + altura + peso;

        }

        
    }
}
