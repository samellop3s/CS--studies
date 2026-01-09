using System;

namespace Aula09
{
    class Program
    {

        // O ENUM (enumeração) é um tipo de dado especial que permite definir um conjunto de constantes nomeadas.
        // Ele é usado para representar um grupo de valores relacionados de forma mais legível e organizada

        enum DiasSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };// Definição do enum DiasSemana 
        static void Main(string[] args)
        {
            DiasSemana dia = DiasSemana.Quarta; // Atribuição de um valor do enum a uma variável
            Console.WriteLine("Dia da semana: " + dia);

            DiasSemana outroDia = (DiasSemana)5; // Conversão de um valor inteiro para o enum
            Console.WriteLine("Outro dia da semana: " + outroDia);

            //O Enum.Parse é um método que converte uma string em um valor do enum correspondente.
            DiasSemana qualquerDia = Enum.Parse<DiasSemana>("Domingo"); // Conversão de string para o enum
            Console.WriteLine("Qualquer dia da semana: " + qualquerDia);

            Console.Write("Qual será o dia q vai cortar o seu cabelo? ");
            string entrada = Console.ReadLine(); //recebera o valor dado pelo usuario
            DiasSemana corte = Enum.Parse<DiasSemana>(entrada); //fara a conversao do valor recebido para o enum
            Console.WriteLine("Seu corte foi marcado pro dia: " + corte); //mostrara o valor convertido
        }
    }
}