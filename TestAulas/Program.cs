using System;

class Program
{
    static void Main()
    {
        // Variável que irá armazenar o nome da fruta
        string fruta;

        // Estrutura de repetição para validar a entrada do usuário
        // O programa continuará pedindo a fruta até que apenas letras sejam digitadas
        do
        {
            Console.WriteLine("Qual fruta o Chico gosta:");

            // ReadLine pode retornar null em versões mais novas do C#
            // O "!" informa ao compilador que assumimos que não será null
            fruta = Console.ReadLine()!;

            // Verifica se a string possui apenas letras
            if (!ApenasLetra(fruta))
            {
                Console.WriteLine("ERRO: Digite apenas letras!");
            }

        } while (!ApenasLetra(fruta));

        // Chama o método LerQuantidade para evitar repetição de código
        // Cada chamada pede um valor diferente ao usuário
        double manha = LerQuantidade($"Quantas {fruta} o Chico comeu pela manhã:");
        double almoco = LerQuantidade($"Quantas {fruta} o Chico comeu no almoço:");
        double janta = LerQuantidade($"Quantas {fruta} o Chico comeu na janta:");

        // Soma todas as quantidades consumidas durante o dia
        double alimento = QuantidadeDeFruta(manha, almoco, janta);

        // Recebe a situação do Chico com base na quantidade consumida
        string situacao = SituacaoDoChico(alimento);

        // Exibe o resultado final
        Console.WriteLine(
            $"\nO Chico gosta de: {fruta}" +
            $"\nQuantidade consumida ao longo do dia: {alimento}" +
            $"\nSituação do Chico: {situacao}"
        );
    }

    /*
        Método responsável por validar se o texto contém apenas letras.

        foreach:
        Percorre caractere por caractere da string.

        char.IsLetter(c):
        Verifica se o caractere atual é uma letra.

        c != ' ':
        Permite espaços no texto.
        Exemplo: "maça verde"

        return false:
        Caso encontre números ou símbolos.

        return true:
        Caso toda a string seja válida.
    */
    static bool ApenasLetra(string texto)
    {
        foreach (char c in texto)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                return false;
            }
        }

        return true;
    }

    /*
        Método responsável por:
        - Mostrar uma mensagem na tela
        - Ler o valor digitado pelo usuário
        - Converter o valor para double
        - Retornar esse valor

        Isso evita repetição de código.
    */
    static double LerQuantidade(string mensagem)
    {
        Console.WriteLine(mensagem);

        // Converte o texto digitado para número decimal
        return Convert.ToDouble(Console.ReadLine());
    }

    /*
        Método responsável por somar
        todas as quantidades consumidas.
    */
    static double QuantidadeDeFruta(double number1, double number2, double number3)
    {
        return number1 + number2 + number3;
    }

    /*
        Método responsável por verificar
        a situação do Chico baseado na quantidade consumida.

        if:
        Até 6 frutas -> satisfeito

        else if:
        Até 9 frutas -> dor de barriga

        else:
        Acima de 9 -> banheiro urgente
    */
    static string SituacaoDoChico(double alimento)
    {
        if (alimento <= 6)
        {
            return "Chico está satisfeito";
        }
        else if (alimento <= 9)
        {
            return "Chico está sentindo algumas dores na barriga";
        }
        else
        {
            return "Chico precisa muito de um banheiro!!!!";
        }
    }
}