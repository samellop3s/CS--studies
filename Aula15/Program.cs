using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
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
                
            }

            switch (transporte)
            {
                
            }
        }
    }
}