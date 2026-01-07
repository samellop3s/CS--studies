using System;

namespace Aula09
{
    class Program
    {
        enum DiasSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };// Definição do enum DiasSemana 
        static void Main(string[] args)
        {
            DiasSemana dia = DiasSemana.Quarta; // Atribuição de um valor do enum a uma variável
            Console.WriteLine("Dia da semana: " + dia);

            DiasSemana outroDia = (DiasSemana)5; // Conversão de um valor inteiro para o enum
            Console.WriteLine("Outro dia da semana: " + outroDia);
        }
    }
}