using System;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arrays / vetores
            int [] n = new int[5];

            int[] num = new int[3]{55, 65, 75};

            //sempre lembrar que o primeiro elemento do array começa no índice 0
            //então um array de 5 posições vai do índice 0 ao índice 4
            //atribuindo valores ao array
            

            n[0] = 10;
            n[1] = 20;
            n[2] = 30;
            n[3] = 40;
            n[4] = 50;
            
            Console.WriteLine(num[2]);
            
        }
    }
}