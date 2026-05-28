using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro numero: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o primeiro numero: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{number1} + {number2} = {Soma(number1, number2)}");
    }
    static int Soma(int number1, int number2)
    {
        return number1 + number2;
    }
}