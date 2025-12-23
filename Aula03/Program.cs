using System;
    class Program
    {
        static void Main()
        {
            byte n1 = 10;
            short n2 = 30000;
            int num = 100;
            char letra = 'S';
            float valor = 10.5f;
            string nome = "Maria";

            var aux = nome;
            Console.WriteLine("O nome do aluno que esta atraso: " + aux);
            Console.WriteLine("O valor da variavel n1 é: " + n1);
            Console.WriteLine("O valor da variavel n2 é: " + n2);
            Console.WriteLine("O valor da variavel letra é: " + letra);
            Console.WriteLine("O valor da variavel valor é: " + valor); 
            Console.WriteLine("O valor da variavel num é: " + num);
        }
    }