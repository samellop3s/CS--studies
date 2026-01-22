using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {

           /* //Arrays / vetores
            int[] n = new int[5];

            //int[] num = new int[3]{55, 65, 75};

            int[] num = { 55, 65, 75 };


            //sempre lembrar que o primeiro elemento do array começa no índice 0
            //então um array de 5 posições vai do índice 0 ao índice 4
            //atribuindo valores ao array
            //a quantidade de arrey é considerado pela quantidade de elementos

            //sempre lembrar que podemos ter varios tipos de arrays, sendo eles inteiros , string, double, char, etc.
            //sempre q for iniciar um array, devemos informar o tipo, dps colocar os colchetes [] e depois o nome do array
            string[] veiculos = new string[3];
            veiculos[0] = "Carro";
            veiculos[1] = "Moto";
            veiculos[2] = "Avião";

            //atribuindo valores ao array
            n[0] = 10;
            n[1] = 20;
            n[2] = 30;
            n[3] = 40;
            n[4] = 50;

            Console.WriteLine(num[2]);

            //1° forma de usar o laço de repetição FOR
            int[] number = { 100, 200, 300, 400, 500 };

            int soma = 0;

            for (int i = 0; i < number.Length; i++)
            {
                soma += number[i];
            }

            double media = soma / number.Length;

            Console.WriteLine("A soma é: " + soma);
            Console.WriteLine("A média é: " + media);

            //2°

            int[] valores = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            int maior = valores[0];
            int menor = valores[0];

            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] > maior)
                {
                    maior = valores[i];
                }
                else if (valores[i] < menor)
                {
                    menor = valores[i];
                }
            }

            Console.WriteLine("O maior valor é: " + maior);
            Console.WriteLine("O menor valor é: " + menor);

            //3°

/*Objetivos:

Mostrar o vetor original

Mostrar o vetor invertido (do último pro primeiro)

Exemplo:
Entrada: [1, 2, 3, 4, 5, 6]
Saída invertida: [6, 5, 4, 3, 2, 1]

            int [] numeros = {1, 2, 3, 4, 5, 6};

            //vetor original
            Console.Write("Vetor original: ");
            for (int i = 0; i < numeros.Length; i++) //o Length pega o tamanho do array
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine();

            //vetor invertido
            Console.Write("Vetor invertido: ");
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.Write(numeros[i] + " ");
            }*/

          /*  int [] test = {1, 2, 3, 4, 5, 6};

            Console.Write("Vetor original: ");
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            } //o i significa que iria iniciar do 0 e ler o array por inteiro.
                Console.WriteLine();

            Console.Write("Vetor invertido: ");
            for (int i = test.Length - 1; i >= 0; i--)//nesta situação o i está iniciando do tamanho do array -1, ou seja, do último elemento.
            {
                Console.Write(test[i] + " ");

            } */

           /* int [] number = {10, 20, 30, 40, 50, 60};//aqui esta sendo criado um array com 6 posições, cada um com seu valor. 

            Console.Write("Vetores corretos: ");
            for (int i = 0; i < number.Length; i++) //aqui vai estar iniciando em 0 e lendo o array por inteiro.

            //for seria um relogio que começa em 0  e vai contando até parar, executando o mesmo bloco de codigo a cada tic

            {
                Console.Write(number[i] + " "); //aqui esta sendo impresso o valo completo do array.
            }*/

            /*int [] valor = {10, 20, 30, 40, 50, 60};//aqui esta sendo criado um array com 6 posições, cada um com seu valor.

            Console.Write("\nVetores invertidos: ");
            for (int i = valor.Length - 1; i >= 0; i--) //aqui o i está iniciando do tamanho do array -1, ou seja, do último elemento.
            {
                Console.WriteLine(valor[i] + " "); //aqui esta sendo impresso o valor completo do array.
            }*/

            int [] valor = {10, 20, 30, 40, 50, 60};

            Console.Write("Vetores: ");
            for(int i = 0; i<valor.Length; i++)
            {
                Console.Write(valor[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Vetores ao contrario: ");
            for(int i = valor.Length -1; i >=0; i--)
            {
                Console.Write(valor[i] + " ");
            }
        }
    }
}