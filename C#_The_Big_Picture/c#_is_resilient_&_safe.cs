// Importa o namespace System, que contém classes básicas como Console
using System;

// Define a classe Program, que é o ponto de entrada do aplicativo
class Program
{
    // Método Main é o ponto de entrada do programa, recebe argumentos da linha de comando
    static int Main(string[] args)
    {
        // Imprime "Hello, World!" no console
        Console.WriteLine("Hello, World!");
        
        // Loop que itera sobre os argumentos passados na linha de comando
        for (var n = 0; n < args.Length; n++)
        {
            // Imprime cada argumento com seu índice
            Console.WriteLine("arg[{0}] = {1}", n, args[n]);
        }
        
        // Chamando a função de soma
        CalculateSum();
        
        // Retorna 0, indicando que o programa terminou com sucesso
        return 0;
    }
    
    // Método que calcula a soma de um array de números
    static void CalculateSum()
    {
        // Declara um array de inteiros com valores de 1 a 5
        var numbers = new int[] { 1, 2, 3, 4, 5 };

        //Aqui ele ira procurar numeros para somar, caso não encontre ele retorna 0
        var sum = numbers.Aggregate(
            0,
            (total, num) => total + num
        );
        // Inicializa a variável sum com 0
        //var sum = 0;
        
        // Loop que soma cada elemento do array
        //for (var n = 0; n < numbers.Length; n++)
        //{
            // Adiciona o valor atual do array à soma
           // sum += numbers[n];
       // }*/


        
        // Imprime a soma total no console
        Console.WriteLine(sum);
    }
}