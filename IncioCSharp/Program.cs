namespace IncioCSharp;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // Exemplos de tipos de variáveis:
        // int idade = 17; //int guarda/aloca números inteiros em sua memória
        // double altura = 1.81; //double guarda/aloca números decimais em sua memória
        // string nome = "Iago"; //string guarda/aloca palavras em sua memória
        // bool ativo = true; //bool guarda/aloca verdadeiro ou falso em sua memória


        // Console.WriteLine imprime pulando linha
        // Console.Write imprime na mesma linha
        // Console.WriteLine(idade);
        // Console.WriteLine(altura);
        // Console.Write(nome);
        // Console.Write(ativo);

        //Entrada de dados:
        // Console.WriteLine("Digite seu nome: ");
        // nome recebe o que foi digitado e armazena nesta variável
        // string nome = Console.ReadLine();

        // Console.WriteLine("Digite a sua idade: ");
        // Parse pega o resultado digitado, que é uma string, e converte para int
        // int idade = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite a sua altura: ");
        // double altura = double.Parse(Console.ReadLine())

        // Concatenação dos dados:
        // Console.WriteLine("Nome: " + nome);
        // Console.WriteLine("Idade: " + idade);

        // //Interpolação de dados:
        // Console.WriteLine($"Olá, eu sou {nome}, tenho {idade} anos.");

        // Adição
        // int n1 = 10;
        // int n2 = 5;
        // int soma = n1 + n2;
        // Console.WriteLine("A soma é: " + soma);

        // Operadores matemáticos
        // Soma             -> int soma = a + b
        // Subtração        -> int sub a - b
        // Multiplicação    -> int multi = a * b
        // Divisão          -> int div a / b
        // Resto da divisão -> int resto = a % b

        // Operadores relacionais
        // Retorna sempre um booleano (verdadeiro/falso)
        // Igual        -> num1 == num2
        // Diferente    -> num1 != num2
        // Maior        -> num1 > num2
        // MaiorOuIgual -> num1 >= num2
        // Menor        -> num1 < num2
        // MenorOuIgual -> num1 <= num2

        // int idade = 18;

        // bool maiorDeIdade = idade >= 18; // true/false
        // bool menorDeIdade = idade < 18;

        // Console.WriteLine("Maior de idade: " + maiorDeIdade);
        // Console.WriteLine("Maior de idade: " + menorDeIdade);

        // Operadores lógicos
        /* 
            Operador AND(E) -> &&
                -> válida se todas as condições forem verdadeiras, se forem, ele retorna true - caso contrário, retorna false.
                -> amarelo && amarelo -> true

            Operador OR(OU) -> ||
                -> válida se pelo menos uma condição for verdadeira, retornando assim, true, se as duas forem falsas, retorna false.
                -> hoje == "Sexta" || hoje == "Sábado" -> true (hoje é Sexta)

            Operador NOT(NÂO) -> !
                -> inverte a condição, se for true vira false e se for false vira true.
                -> !true    -> false
                -> !false   -> true
        */

        // bool condicao1 = true;
        // bool condicao2 = false;

        // Console.WriteLine(condicao1 && condicao2); // false
        // Console.WriteLine(condicao1 || condicao2); // true
        // Console.WriteLine(!condicao1); // false

        // int idade = 20;
        // bool possuiCarteira = false;
        // bool podeDirigir = idade >= 18 && possuiCarteira;
        // Console.WriteLine("Pode dirigir: " + podeDirigir) // false

        // int numero = 5;
        // bool resultado = numero < 0 || numero > 10;
        // Console.WriteLine("Fora do intervalo 0 a 10: " + resultado); // false

        bool estaChovendo = false;
        Console.WriteLine(!estaChovendo) // true (estaChovendo foi negado com !)

    }
}
