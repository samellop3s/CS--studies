using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {

            //Goto serve para desviar o fluxo de execução do programa para um ponto específico
            //do código identificado por um rótulo (label).

            inicio: 
            Console.Clear();
            Console.WriteLine("Bem-vindo ao sistema de escolha de viagem!");

            //o SWITCH CASE é uma estrtura condicional que permite testar uma variável
            //contra vários valores possíveis, executando o bloco de código correspondente

            Console.WriteLine("Escolha o local de viagem:");
            Console.WriteLine("1 - Praia || 2 - Montanha || 3 - Campo || 4 - Cidade || 5 - Interior");
            Console.Write("Digite o número correspondente ao local desejado:");
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o modo de transporte: (a) Carro || (b) Avião || (c) Trem || (d) Ônibus");
            Console.Write("Digita a letra correspondente ao modo de transporte desejado:");
            char transporte = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu viajar para a praia.");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu viajar para a montanha.");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu viajar para o campo.");
                    break;
                case 4:
                    Console.WriteLine("você escolheu viajar para a cidade.");
                    break;
                case 5:
                    Console.WriteLine("Você escolheu viajar para o interior.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 5.");
                    break;
            }



            if (escolha<0 || escolha>5)
            {
                Console.WriteLine("Não é possível determinar o modo de transporte devido à escolha inválida do local.");
            }
            else
            {
                switch (transporte)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("Você escolheu viajar de carro.");
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("Você escolheu viajar de avião.");
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("Você escolheu viajar de trem.");
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine("Você escolheu viajar de ônibus.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma letra entre a, b, c ou d.");
                        break;
                }
            }   
                Console.WriteLine("Deseja fazer outra viagem? (s/n)");
                escolha = char.Parse(Console.ReadLine());
                if (escolha == 's' || escolha == 'S'){
                    goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Obrigado por usar o sistema de escolha de viagem! Boa viagem!");
            }
        }
    }
}   