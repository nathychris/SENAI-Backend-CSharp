using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = {2,7,9};
            Console.WriteLine(vetor(valores));
        }

        static double vetor (double[] valores) {

            double resultado = 0;
            
            for (int i = 0; i < valores.Length; i++){
            
                if( i==0 ){

                resultado = valores[i];

                }
                if(resultado < valores[i]){
                    resultado = valores [i];
                }
            }
           return resultado;
        }
    }
}
