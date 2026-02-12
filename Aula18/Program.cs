using System;

namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            //nesta aula foi passado como funciona a matrix com 2 vetores ou mais
            int[,] n = new int [3,5]; //aqui estou indicando que sera uma matrix bidimensional, onde vai receber 3 linhas para 5 colunas

            //aqui estou passando o valor de cada vetor
            n[0,0] = 10; n[1,0] = 60; n[2,0] = 25;
            n[0,1] = 20; n[1,1] = 70; n[2,1] = 35;
            n[0,2] = 30; n[1,2] = 80; n[2,2] = 45;
            n[0,3] = 40; n[1,3] = 90; n[2,3] = 55;
            n[0,4] = 50; n[1,4] = 15; n[2,4] = 65;

            Console.WriteLine(n[1,3]);


        }
    }
}