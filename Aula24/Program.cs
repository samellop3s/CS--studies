using System;

namespace Test
{
    class Aula24
    {
        static void Main()
        {
            Numbers(10, 36); //este metodo esta recebendo os valores do numero
        }

        static void Numbers(int n1, int n2)
        {
            int res = (n1 + n2);
            Console.Write("A soma de {0} + {1} é igual a {2}", n1, n2, res);//aqui sera impresso tanto a mensagem quanto o valor da soma
        }
    }
}