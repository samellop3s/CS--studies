using System;


namespace tstLogica
{
    class Program
    {
        static void Main()
        {
            //OPERAÇÃO QUE FAZ A SOMA ENTRE NUMEROS INTEIROS

           Console.WriteLine("Informe o 1º numero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o 2º numero: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = SomaNumbers(number1, number2);
            Console.WriteLine($"O resultado da soma entre {number1} + {number2} = {result}");

            //OPERAÇÃO QUE DEFINE QUAL É O NUMERO PAR E O NUMERO IMPAR 
            Console.WriteLine("informe um numero: ");
            int value = Convert.ToInt32(Console.ReadLine());

            string resultado = ParOuImpar(value);
            Console.WriteLine($"o {value} é um número {resultado}");
        }
        static int SomaNumbers(int number1, int number2)
        {
            return number1 + number2;
        }


        static string ParOuImpar(int value)
        {   
            if (value % 2 == 0)
            {
                return "é par";
            }else
            {
                return "é impar";   
            }
        }
    }
}