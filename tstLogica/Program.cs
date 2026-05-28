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
                name = Console.ReadLine()!; // aqui será entregue o valor vindo do teclado

                if (!ApenasLetra(name))
                {
                    Console.WriteLine("ERRO! favor inserir somente letras");
                }
            }while(!ApenasLetra(name));
        }
          /*
        Método responsável por validar se o texto contém apenas letras.

        foreach:
        Percorre caractere por caractere da string.

        char.IsLetter(c):
        Verifica se o caractere atual é uma letra.

        c != ' ':
        Permite espaços no texto.
        Exemplo: "maça verde"

        return false:
        Caso encontre números ou símbolos.

        return true:
        Caso toda a string seja válida.
    */
        static bool ApenasLetra(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}