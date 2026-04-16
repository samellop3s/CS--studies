using System;
using System.ComponentModel;

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
            int v1 = Convert.ToInt32(Console.ReadLine());//aqui será a entrada dos valores vindo direto do teclado e sendo convertido.
            int v2 = Convert.ToInt32(Console.ReadLine());
            Numbers(v1, v2);//aqui esta sendo chamada as variaveis.
        }

        static void Numbers(int v1, int v2)
        {
            int result = v1 + v2;
            Console.WriteLine($"A soma entre {v1} + {v2} é igual a {result}");
        }
    }
}