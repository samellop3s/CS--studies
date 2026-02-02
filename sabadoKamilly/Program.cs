using System;


namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Vetores na ordem correta: ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Vetores ao contrario: ");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i] + " ");
            }

            string[] frutas = {"Banana", "Pera", "UVa", "Laranja", "Tomate"};

            bool encontrou = false;

            Console.WriteLine("Nesta cesta tem a Banana?");

            foreach(string fruta in frutas)
            {
                if(fruta == "Banana")
                {
                    encontrou = true;
                    break;
                }
            }
            if (encontrou)
            {
                Console.WriteLine("OBAAAA, vc encontrou a banana!!!!");
            }
            else
            {
                Console.WriteLine("Poxa, vc n encontrou a banana");
            }

            int[,] numero = new int [3,5];

            numero [0,0] = 10; numero [0,1] = 20; numero [0,2] = 30; numero [0,3] = 40; numero [0,4] = 50;
            numero [1,0] = 60; numero [1,1] = 70; numero [1,2] = 80; numero [1,3] = 90; numero [1,4] = 15;
            numero [2,0] = 25; numero [2,1] = 35; numero [2,2] = 45; numero [2,3] = 55; numero [2,4] = 65;

            Console.WriteLine(numero[1,4]);
        }
    }
}