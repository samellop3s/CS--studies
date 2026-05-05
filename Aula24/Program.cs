using System;
using System.Globalization;
using System.Runtime.Intrinsics;

namespace Aula24
{
    class AppTest
    {
        static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                int digitado = number % 10;
                Console.WriteLine(digitado);
                number /= 10;
            }
        }

      /*  static int Soma( int number1, int number2)
        {
            int res = number1 + number2;
            Console.WriteLine($"A soma entre {number1} + {number2} é igual a {res}");
            return res;
        } */
    }
}