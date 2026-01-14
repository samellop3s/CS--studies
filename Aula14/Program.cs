using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condicional if-else

            int n1, n2, n3, n4, res;
            res = n1 = n2 = n3 = n4 = 0;

            //>= 60 Aprovado
            //50=< 60 Recuperação
            //< 50 Reprovado

            Console.Write("Digite o valor de n1: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 60)
            { if(n1 >= 90)
                {
                    Console.WriteLine("Aprovado com louvor");
                }else
                {
                    Console.WriteLine("Aprovado");
                }
            }
            else
            {
                if(n1 >= 50)
                {
                    Console.WriteLine("Recuperação");
                }else
                {
                    Console.WriteLine("Reprovado");
                }
            }
        }
    }
}   