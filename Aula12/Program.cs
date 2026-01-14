using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comando condicional com if/else
            Console.Write("Digite a nota do aluno: ");
            int nota = int.Parse(Console.ReadLine());

            if(nota >= 60)
            {//se o resultado da condição for verdadeiro
                Console.WriteLine("Aprovado");
            }
            else
            {//se o resultado da condição for falso
                Console.WriteLine("Reprovado");
            }
        }
    }
}