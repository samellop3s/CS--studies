using System;
<<<<<<< HEAD
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
=======
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro numero: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o primeiro numero: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{number1} + {number2} = {Soma(number1, number2)}");
    }
    static int Soma(int number1, int number2)
    {
        return number1 + number2;
>>>>>>> 411d01ce429708d6fbe1b42d8b11188d5e62319a
    }
}