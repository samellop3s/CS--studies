using System;

class Program {
    static void Main()
    {
        
        string fruta;

        do {
            Console.WriteLine("Qual fruta o chico gosta: ");
            fruta = Console.ReadLine();

            if(!ApenasLetra(fruta)){
                Console.WriteLine("ERRO: Digite apenas letras!");
            }
        }while(!ApenasLetra(fruta));

        Console.WriteLine($"Quantas {fruta} o chico comeu pela manhã: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Quantas {fruta} o chico comeu no horario do almoço: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Quantas {fruta} o chico comeu na janta: ");
        double number3 = Convert.ToDouble(Console.ReadLine());

        double alimento = QuantidadeDeFruta(number1, number2, number3);

        string situacao = SituacaoDoChico(alimento);

        Console.WriteLine($"O chico gosta de: {fruta} \nqual foi a quantidade que ele comeu ao longo do dia?: {alimento} \nqual a situação do chico?: {situacao}");

    }

    static bool ApenasLetra(string texto){
        foreach (char c in texto)
        {
            if(!char.IsLetter(c)) {
                return false;
            }
        }

        return true;
    }

    static double QuantidadeDeFruta(double number1, double number2, double number3)
    {
        return (number1 + number2 + number3);
    }

    static string SituacaoDoChico(double alimento)
    {
        if (alimento <= 6)
        {
            return "Chico esta satisfeito";
        }
        else if (alimento <= 9)
        {
            return "Chico esta sentindo algumas dores na barriga";
        }
        else {
            return "Chico precisa muito de um banheiro!!!!";
        }
    }
}