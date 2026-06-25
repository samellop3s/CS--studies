using System;


namespace tstLogica
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Informe o 1º numero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o 2º numero: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = SomaNumbers(number1, number2);
            Console.WriteLine($"O resultado da soma entre {number1} + {number2} = {result}");
        }
        static int SomaNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}