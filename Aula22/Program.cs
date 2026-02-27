using System;

namespace AppAula
{
    class Aula22 {
        static void Main(string[] args)
        {
            //AUla sobre loop foreach

            //enquanto o loop for faz a inicialização 
            //o foreach faz a leitura 

            int[] number = new int [3] {12,55,33};

           /* for(int i = 0; i<number.Length; i++) ele fara a incialização da funcao 
            {
                Console.Write(number[i] + " ");
            }*/

            foreach(int n in number) // ja aq fara a leitura
            {
                Console.Write(n + " ") ;
            }
        }
    }
}