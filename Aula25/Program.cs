using System;

namespace Aula25
{
    class Program
    {
        /* Passagem por valor e por referência
        sempre que ocorrer uma passagem por valor (usa o mesmo argumento passado porem cria um novo local na memoria): vai ser criada uma "copia" mas n ira alterar a "original"
        agora, se ocorrer uma passagem por referencia (usa o endereço de memoria que foi passada como argumento): sempre que for feita uma alteração, será direta na "original"

        obs: sempre que for passar uma passagem por referencia, use "ref" para a identificar a ação que esta sendo solicitada
        */
        static void Main()
        {
            int num = 500;
            Dobrar(ref num);
            Console.WriteLine(num);
        }

        static void Dobrar(ref int valor)
        {
            valor*=2;
        }
    }
}