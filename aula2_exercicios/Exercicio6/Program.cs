using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            
        int idade;
        string msg;

        Console.WriteLine("Digite sua idade");
        idade = int.Parse(Console.ReadLine());

        if( idade <= 6 ){

            msg = "até 3 anos";

        } else if ( idade > 6 && idade < 10) {

            msg = "Maiores de 6 anos ou livre";

        } else if ( idade > 10 && idade < 13){

            msg = "Maiores de 10 anos";

        } else if (idade > 13 && idade < 17){
           
            msg = "Maiores de 13 anos";

        }else if (idade > 17 && idade < 18){

            msg = "Maiores de 17 anos";
        }else if (idade > 18){

            msg = "Maiores de 18 anos";
        }

        Console.WriteLine("msg");





        }
    }
}
