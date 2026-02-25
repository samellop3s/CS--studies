using System;

namespace Apptest
{
    class sabadoKamilly
    {
        static void Main(string[] args)
        {
            string senha = "123";        
            string senhaUser;
            int tentativas = 0; //n esquecer de atribuir o valor inical a variavel.

            do
            {
                Console.Clear();
                Console.WriteLine("Informe sua senha: ");
                senhaUser = Console.ReadLine();
                tentativas++;
                
            }while(senha != senhaUser );

            Console.Clear();
            Console.WriteLine("Senha correta, seja bem vindo!!!!. tentativas{0}", tentativas);
        }
    }
}