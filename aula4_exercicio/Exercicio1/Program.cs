using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] posição = new double[10];

            for ( int i = 0; i <=9; i++){

                Console.WriteLine("Digite sua nota");
                posição[i] = double.Parse(Console.ReadLine());
            }

             Console.WriteLine(posição[9]*5);
        }
    }
}
