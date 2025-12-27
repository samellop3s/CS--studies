using System; 

class Program
{
    static void Main(string[] args)
    {
        //WriteLine : Faz a impressao do resultado no console e faz a quebra de linha
        //Write : Faz a impressao do resultado no console sem quebra de linha
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Starting Aula 06...");

        //Fazendo a utilização dos indices.
        //Sabemos que a inicialização dos indices começa em 0.
        //dessa forma, utilizando eles ficara mais facil na organização dos dados.
        //Segue exemplo:
        int n1, n2, n3;

        n1 = 10;
        n2 = 20;
        n3 = 30;
        //o \n ele serve para fazer uma quebra de linha no console.
        //o \t ele serve para dar um tab no console.
        Console.WriteLine("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}\n", n1, n2, n3);

        double valorCompra = 5.50;
        double valorvenda;
        double lucro = 0.20;
        string produto = "Coxinha";
        
        valorvenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto:.........{0,15}", produto);
        Console.WriteLine("Val. Compra:.....{0,15:c}", valorCompra);
        Console.WriteLine("Val. Venda:......{0,15:c}", valorvenda);
        Console.WriteLine("Lucro:...........{0,15:p}", lucro);

        //0 - indice do valor
        //,15 - espaço reservado para o valor (15 caracteres)
        //:c - formatação do valor (moeda)
        //:p - formatação do valor (porcentagem)
    }
}