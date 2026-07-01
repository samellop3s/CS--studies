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

            //MAIOR ENTRE 3 NUMEROS

            Console.WriteLine("Digite o primeiro numero: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            string resumo = MaiorEntreOsTres(valor1, valor2, valor3);
            Console.WriteLine($"O valor: {resumo}");

            //DESENVOLVER UMA CALCULARDORA QUE SOLICITE 2 NUMEROS

            Console.Write("Digite um valor: " + " ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um valor: " + " ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - soma; \n2 - subtração; \n3 - divisao \n4 - multiplicação");
            int operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    resultado = Soma(numero1, numero2);
                    Console.WriteLine($"{numero1} + {numero2} = {resultado}");
                break;
                case 2:
                    resultado = Subtrair(numero1, numero2);
                    Console.WriteLine($"{numero1} - {numero2} = {resultado}");
                break;
                case 3:
                    resultado = Divisao(numero1, numero2);
                    Console.WriteLine($"{numero1} / {numero2} = {resultado}");
                break;
                case 4:
                    resultado = Multiplicar(numero1, numero2);
                    Console.WriteLine($"{numero1} * {numero2} = {resultado}");
                break;
                default :
                    Console.WriteLine("Opção invalida!");
                break;
            }

            /*int sobra = CalcularOperacoes(numero1, numero2);
            Console.Write($"O resultado da operação entre os numeros{numero1} e {numero2} = {sobra}" + " ");*/
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

        static string MaiorEntreOsTres(int valor1, int valor2, int valor3)
        {
            if(valor1 > valor2 && valor1 > valor3)
            {
                return "valor1 é maior" ;
            }else if(valor2 > valor1 && valor2 > valor3)
            {
                return "valor2 é maior";
            }else
            {
                return "valor3 é maior";
            }
        }

        

        static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        static double Divisao(int numero1, int numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Não é possivel dividir por zero!");
                return 0;
            }
                return (double)numero1 / numero2;
        }
        static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
    }
}