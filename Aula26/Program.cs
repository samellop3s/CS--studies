using System;

namespace Aula26
{
    class Program
    {

        /*O argumento out funciona quase igual ao ref (mas só no quesito de chamado)
        pois ele serve para fazer o metodo retornar dois ou mais valores diferentes
        o out nao tem um limite para ser chamado, pode ser mencionado quantas vezes for necessario
        */
        static void Main()
        {
            int divid = 10;
            int divis = 5;
            int cociente=Divide(divid, divis, out int resto);

            Console.WriteLine($"o Resultado da divisao é :{divid} / {divis} = {cociente} o resto é: {resto}");

        }

        static int Divide(int dividendo, int divisor, out int resto)
        {
            int cociente = dividendo/divisor;
            resto = dividendo%divisor;
            return cociente;
        }
    }
}