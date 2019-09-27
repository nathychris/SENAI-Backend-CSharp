using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
             imprimeDataHora ();
        }
          static void imprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.DayOfWeek);
          }
    }
}
