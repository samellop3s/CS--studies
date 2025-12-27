using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //const seria uma variável imutável.
        const string name = "Samuel Ferreira Lopes";
        const int year = 21;
        const double pi = 3.14;

        Console.WriteLine("Constantes:");
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Idade: {year}");
        Console.WriteLine($"Pi: {pi}");
    }
}