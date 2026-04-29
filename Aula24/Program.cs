using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Test
{
    class Aula24
    {
       /* static void Main()
        {
            Numbers(10, 36); //este metodo esta recebendo os valores do numero
            //proximo metodo a ser testado sera com valores direto do teclado.
        }

        static void Numbers(int n1, int n2)
        {
            int res = (n1 + n2);
            Console.Write("A soma de {0} + {1} é igual a {2}", n1, n2, res);//aqui sera impresso tanto a mensagem quanto o valor da soma
        }*/

        static void Main()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Numbers(num1, num2);
        }

        static void Numbers(int num1, int num2)
        {
            int soma = num1 + num2;
            Console.WriteLine($"O resultado da soma entre {0} + {1} é igual a {2}", num1, num2, soma);
        }
    }
}