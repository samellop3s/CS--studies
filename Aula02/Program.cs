using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eu sou o seu primeiro programa em C#!");
            if(args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            }else
            {
                Console.WriteLine("Nenhum argumento foi passado.");
            }
        }
    }
}