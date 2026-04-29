namespace Aula06;

class Program
{
    static void Main(string[] args)
    {
        /*
            for -> Usado para quando você sabe quantas vezes sera repetido.

            while -> Usado para quando você não sabe quantas vezes sera repetido e a repetição acontece enquanto uma condição for verdadeira.

            do/while -> É parecido com while, mas a diferença é que, mesmo que a condição seja falsa ele executa pelo menos uma vez: "Faz primeiro e depois pergunta".

            foreach -> Usado para percorrer listas. 
        */

        // EXEMPLO FOR
        // int i = 1 -> Inicializador, valor inicial.
        // i <= 5    -> Condição, se for verdadeiro, continua executando.
        // i++       -> Iterador, serve para acrescentar um valor a mais dentro do i (i = i + 1).

        // for(int i = 1; i<= 5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int soma = 0;

        // for(int i = 1; i <= 10; i++)
        // {
        //     soma = soma + i;
        //     // soma += 1;
        //     Console.WriteLine("Soma atual: " + soma);
        // }

        // Console.WriteLine("Soma total: " + soma);



        // EXEMPLO WHILE
        // int contador = 1;

        // while(contador <= 5)
        // {
        //     Console.WriteLine(contador);
        //     // Contador recebe contador + 1
        //     contador++;
        // }
        
        // Console.WriteLine();

        // int n1 = 0;

        // while(n1 <= 0)
        // {
        //     Console.WriteLine("Digite um número maior que zero: ");
        //     n1 = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Número válido: " + n1);

        

        // EXEMPLO DO/WHILE
        // Executa primeiro e depois pergunta.
        // int n1 = 0;

        // do
        // {
        //     Console.Write("Digite um número maior do que zero: ");
        //     n1 = int.Parse(Console.ReadLine());
        // }
        // while (n1 <= 0); // Enquanto a condição for verdadeira.

        // Console.WriteLine("Número válido: " + n1);



        // MENU
        // int op;

        // do
        // {
        //     Console.WriteLine("1 - Continuar.");
        //     Console.WriteLine("2 - Sair.");

        //     op = int.Parse(Console.ReadLine());

        // } while (op != 2); // Condição - enquanto a opção for diferente de 2, a repetição vai continuar.

        // Console.WriteLine("Programa encerrado!");



        // EXEMPLO FOREACH
        // Acessar os elementos dentro de uma rede/lista.
        // [] 
        // string[] nomes = {"Ana", "Carlos", "Maria" };

        // Para cada nome em nomes.
        // foreach (string nome in nomes) // Variável auxiliar, ele pega cada uma das variáveis dentro da lista, coloque nomes intuitivos.
        // {
        //     // Imprima o nome.
        //     Console.WriteLine(nome);
        // }

        int[] numeros = (2, 4, 6, 8);
        int soma = 0;

        foreach (int numero in numeros)
        {
            soma += numero;
            // soma = soma + numero;
        }

        Console.WriteLine("Soma: " + soma);
    }
}
