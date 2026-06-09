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
                name = Console.ReadLine(); //vai receber o valor desejado pelo teclado

                if (!ApenasLetras(name)) //logo caira em um if para ser verificador se o valor é valido ou nao, caso seja valido ele ira para o proximo passo, caso seja invalido ele ira mostrar a mensagem de erro e pedir para inserir novamente
                {
                    Console.WriteLine("ERRO! favor inserir novamente (apenas letras)");//mensagem de erro caso o valor seja invalido
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