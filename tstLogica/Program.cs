using System;

namespace TestProgram
{
    class Program
    {
        static void Main()
        {   //variavel que ira armazenar o valor
            string name;
            do
            {
                Console.WriteLine("Whats your name?");
                name = Console.ReadLine(); // aqui será entregue o valor vindo do teclado

                if (!ApanesLetra(name));
                {
                    Console.WriteLine("ERRO! favor inserir somente letras");
                }
            }while(!ApenasLetra(name));
        }
    }
}