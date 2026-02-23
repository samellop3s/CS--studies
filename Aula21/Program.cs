using System;

namespace AppTest
{
    class Aula21
    {
        static void Main(string[] args)
        {
            //nesta aula vms aprender sobre loop do while
            //primeira diferença entre o while e do while é a sua sintaxe 

           /* while(cond)//o while ele primeiro testa e dps executa
            {
                
            }*/

            //o do while, executa a função pelo menos uma unica vez
            //ja o while nao faz essa execução

            string senha = "123";
            string senhaUser;
            int tentativas=0;

            do{//ja o dowhile ele executa primeiro e dps testa
                Console.Clear();
                Console.WriteLine("Digite sua senha: ");
                senhaUser = Console.ReadLine();
                tentativas++;
            } while( senha != senhaUser);

            Console.Clear();
            Console.WriteLine("Senha correta, tentativas:{0}", tentativas);
        }
    }
}