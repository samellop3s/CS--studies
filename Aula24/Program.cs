using System;
using System.Runtime.Intrinsics;

namespace Aula24
{
    class AppTest
    {
        static void Main()
        {   
            Console.WriteLine("Digitar valor do number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digitar valor do number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int soma = Soma (number1, number2);
        }

        static int Soma( int number1, int number2)
        {
            int res = number1 + number2;
            Console.WriteLine($"A soma entre {number1} + {number2} é igual a {res}");
            return res;
        }
    }
}