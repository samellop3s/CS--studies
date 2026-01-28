using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop For 
            for(int num = 0; num < 10; num++)//vai fazer uma contagem até dar o numero imposto por num.
            {
                //apos fazer a contagem e chegar no valor correto, vai encerrar o loop e fazer a impressao completa.
                Console.WriteLine("CFB cursos");
                break;//comando para sair do loop
            }

            Console.Write("==============================\n");

            int [] numbers = {10,20,30,40,50,60,70,80,90,100};
            Console.Write("\nImprimindo os valores do Array\n");

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            Console. Write("\nImprimindo os valores do Array ao contrario\n");
            for(int i = numbers.Length -1; i>=0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            
            Console.WriteLine();
            Console.Write("==============================\n");

            string [] carros = {"BMW", "AUDI", "FERRARI", "MERCEDES", "VOLVO"};

            bool encontrou = false;

            foreach(string carro in carros)
            {
                if( carro == "FERRARI" )
                {
                    encontrou = true;
                    break;
                }
            }if (encontrou)
            {
                Console.WriteLine("Carro encontrado!");
            }else
            {
                Console.WriteLine("Carro nao encontrado!");
            }

            Console.Write("==============================\n");
        }
    }
}