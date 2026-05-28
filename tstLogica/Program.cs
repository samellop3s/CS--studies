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
                Console.WriteLine("Favor inserir seu nome: ");
                name = Console.ReadLine();

                if (!ApenasLetras(name))//esta fazendo a chamada do metodo pra validação da entrada do valor;
                {
                    Console.WriteLine("ERRO! favor digitar corretamente");
                }
            }while(!ApenasLetras(name));
        }

        static bool ApenasLetras(string texto)
        {
            foreach(char c in texto)//fara a leitura completa do valor que sera entregue;
            {
                if(!char.IsLetter(c) && c != ' ')//o char vai fazer a verificação pra ver se o caracter é uma letra;
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}