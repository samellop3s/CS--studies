using System;

namespace TestProgram
{
    class Program
    {
        static void Main()
        {
         string name;

            do
            {
                Console.WriteLine("Favor informar seu nome: ");
                name = Console.ReadLine();

                if (!ApenasLetras(name))
                {
                    Console.WriteLine("ERRO! favor inserir novamente (apenas letras)");
                }
            }while(!ApenasLetras(name));
        }

        static bool ApenasLetras(string texto)
        {
            foreach(char c in texto)
            {
                if(!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}