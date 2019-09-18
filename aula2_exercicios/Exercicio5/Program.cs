using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Digite o numero 1");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 2");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 3");
            num3 = int.Parse(Console.ReadLine());

            if ( (num1 > num2) && (num1 > num3) ){
                
                Console.WriteLine(num1);

            } else if( num2 > num3){

                Console.WriteLine(num2);
                
            }else{
                Console.WriteLine(num3);
            }
        }
    }
}
