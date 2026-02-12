using System;

namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            int i = 0;
            while (i<number.Length)
            {
                number[i]=0;
                Console.WriteLine(number[i]);
                i++;
            }
            Console.WriteLine("Fim do loop");
        }
    }
}