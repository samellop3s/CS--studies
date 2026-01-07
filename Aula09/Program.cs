using System;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bitwise é uma operação de baixo nível que manipula bits individuais, 
            //ou padrões de bits, em números binários. É um tipo de computação direta com representações binárias de dados
            
            //<< Deslocamento para a esquerda dos bits dobra o valor a cada deslogamento    
            //>> Deslocamento para a direita dos bits reduz o valor pela metade a cada deslocamento

            int num = 10; 

            num = num << 2; // Deslocamento para a esquerda em 2 bits (equivale a multiplicar por 4)
            Console.WriteLine(num); 
        }
    }
}