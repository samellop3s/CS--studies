using System;
using System.Globalization;

namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //o loop for serve quando sabemos a quantidade de valores q desejamos.
            //ja o  while, serve quando n sabemos a quantidade dos valores.


            /* int[] number = new int[10];

             int  i=0;//no loop while sempre passar o valor fora antes de iniciar a func
             while (i<number.Length)
             {
                 number[i] = 0;
                 Console.WriteLine(number[1]);
                 i++;//semopre verificar se tem a acao de incremento ou decremento
             }

             Console.WriteLine("Fim do loop");*/

            /*int[] num = new int[10];

            int i=num.Length -1;
            while (i >0)
            {
                num[i] = 0;
                Console.WriteLine(num[i]);
                i--;
            }
            Console.WriteLine("finalizado");*/

            /* int [] number = new int [10]; //estamos informando a quantidade q deve ser repetida

             int i = 0;//informando q o i sera iniciado em 0

             while(i<number.Length)
             {
                 number[i] = 0;
                 Console.WriteLine("Tst");
                 i++;//após o teste da condição e retornar corretamente será somado +1
             }

             Console.WriteLine("ação finalizada");*/

            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Valor dos vetores: ");
                Console.WriteLine(number[i]);
            }

            Console.WriteLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write("valores invertidos: ");
                Console.WriteLine(number[i]);
            }

        }
    }
}