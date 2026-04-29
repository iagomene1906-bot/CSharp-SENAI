namespace ResolucaoExercicios;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        //! Resolução do nível fácil - atividade 1
        // Console.WriteLine("Digite um número: ");
        // int numero = int.Parse(Console.ReadLine());

        // Console.WriteLine("Dobro: " + (numero * 2));

        // // int dobro = numero * 2;
        // // Console.WriteLine("Dobro: " + dobro);


        // //! Resolução do nível fácil - atividade 2
        // int n1 = 10;
        // int n2 = 12;

        // int soma = n1 + n2;

        // Console.WriteLine("Soma: " + soma);

        // //! Resolução do nível fácil - atividade 3
        // int numero = 10;

        // bool ePar = numero % 2 == 0;
        // // bool eImpar = !(numero % 2 == 0); // inverso

        // Console.WriteLine("É par? " + ePar);

        // //! Resolução do nível fácil - atividade 4
        // int n1 = 20;
        // int n2 = 5;

        // Console.WriteLine("O primeiro é maior: " + (n1 > n2)); //true
        // Console.WriteLine("O segundo é maior: " + (n2 > n1)); //false
        // Console.WriteLine("São iguais: " + (n2 == n1)); //false

        // //! Resolução do nível fácil - atividade 5
        // int idade = 18;
        // Console.WriteLine("Maior de idade: " + (idade >= 18));

        // //! Resolução do nível médio - atividade 1
        // Console.Write("Digite a primeira nota: ");
        // double nota1 = double.Parse(Console.ReadLine());

        // Console.Write("Digite a segunda nota: ");
        // double nota2 = double.Parse(Console.ReadLine());

        // double media = (nota1 + nota2) / 2;

        // Console.WriteLine("Média: " + media);
        // Console.WriteLine("Aprovado: " + (media >= 6));

        // //! Resolução do nível médio - atividade 2
        // int numero = 25;

        // Console.WriteLine("Está entre 50 e 100: " + (numero >= 50 && numero <= 100));

        //! Resolução do nível médio - atividade 3
        // decimal valor = 800M;

        // decimal valorFinal = valor - (valor * (10M/100M));
        // // decimal valorFinal = valor - (valor * 0.10M);

        // Console.WriteLine("Valor com desconto: " + valorFinal);

        // //! Resolução do nível médio - atividade 4
        // int numero = -18;

        // Console.WriteLine("Positivo: " + (numero > 0));
        // Console.WriteLine("Negativo: " + (numero < 0));
        // Console.WriteLine("Zero: " + (numero == 0));

        // //! Resolução do nível médio - atividade 5
        // Console.Write("Digite sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // Console.WriteLine("Pode votar: " + (idade >= 16));

        // //! Resolução do nível difícil - atividade 1
        // Console.Write("Digite o usuário: ");
        // string usuario = Console.ReadLine();

        // Console.Write("Digite a senha: ");
        // string senha = Console.ReadLine();

        // Console.WriteLine("Login realizado: " + (usuario == "admin" && senha == "1234"));

        // //! Resolução do nível difícil - atividade 2
        // int n1 = 27;
        // int n2 = 35;
        // int n3 = 54;

        // Console.WriteLine("O primeiro número é maior: " + (n1 > n2 && n1 > n3));
        // Console.WriteLine("O segundo número é maior: " + (n2 > n1 && n2 > n3));
        // Console.WriteLine("O terceiro número é maior: " + (n3 > n1 && n3 > n2));
        // Console.WriteLine("Os números são iguais: " + (n1 == n2 && n1 == n3));

        // //! Resolução do nível difícil - atividade 3
        // decimal salario = 1500m;

        // decimal aumento10 = salario + (salario * 0.10m);
        // decimal aumento20 = salario + (salario * 0.20m);

        // Console.WriteLine("Salário com 10%: " + aumento10);
        // Console.WriteLine("Salário com 20%: " + aumento20);

        // Console.WriteLine("Recebe 10%: " + (salario > 2000));
        // Console.WriteLine("Recebe 20%: " + (salario <= 2000));

        // //! Resolução do nível difícil - atividade 4
        // int ano = 2026;
        // Console.WriteLine("Ano bissexto simplificado: " + (ano % 4 == 0));

        //! Resolução do nível difícil - atividade 5
        Console.Write("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Possui convite? (true/false)");
        bool convite = bool.Parse(Console.ReadLine());

        Console.WriteLine("Acesso permitido: " + (idade >= 18 && convite));


    }
}
