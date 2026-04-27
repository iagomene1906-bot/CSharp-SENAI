namespace Aula03;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // NÍVEL FÁCIL

        // 1 EXERCÍCIO
        // Console.Write("Digite um número: ");
        // int num = int.Parse(Console.ReadLine());
        // Console.WriteLine("O dobro do número digitado é: " + (num * 2));

        // 2 EXERCÍCIO
        // Console.Write("Digite o primeiro valor para soma: ");
        // double num1 = double.Parse(Console.ReadLine());
        // Console.Write("Digite o segundo valor para soma: ");
        // double num2 = double.Parse(Console.ReadLine());
        // Console.WriteLine("A soma dos valores é: " + (num1 + num2));

        // 3 EXERCÍCIO
        // Console.Write("Digite um número: ");
        // int num = int.Parse(Console.ReadLine());
        // bool par = num % 2 == 0;
        // Console.WriteLine($"{num} é par: {par}");

        // 4 EXERCÍCIO
        // Console.Write("Digite o primeiro valor: ");
        // int n1 = int.Parse(Console.ReadLine());
        // Console.Write("Digite o segundo valor: ");
        // int n2 = int.Parse(Console.ReadLine());
        // Console.WriteLine($"O primeiro valor é maior que o segundo: {n1 > n2}");

        // 5 EXÉRCÍCIO
        // Console.Write("Digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());
        // bool maiorDeIdade = idade >= 18;
        // Console.WriteLine("Maior de idade: " + maiorDeIdade);

        // NÍVEL MÉDIO

        // 1 EXERCÍCIO
        // Console.Write("Digite a sua primeira nota: ");
        // int n1 = int.Parse(Console.ReadLine());
        // Console.Write("Digite a sua segunda nota: ");
        // int n2 = int.Parse(Console.ReadLine());
        // int m = (n1 + n2) / 2;
        // Console.WriteLine($"Sua média é: {m}, você passou: {m >= 6}");

        // 2 EXERCÍCIO
        // Console.Write("Digite um número: ");
        // int n1 = int.Parse(Console.ReadLine());
        // Console.WriteLine($"O número que você digitou está entre 50 e 100: {(50 <= n1) && (n1 <= 100)}");

        // 3 EXERCÍCIO
        // Console.Write("Digite o valor do produto para ver se terá desconto: ");
        // decimal valor = decimal.Parse(Console.ReadLine());
        // decimal vF = valor - (valor * 0.10M);
        // Console.WriteLine("Valor do produto: " + valor);
        // Console.WriteLine("Valor do produto com desconto: " + vF);

        // 4 EXERCÍCIO
        // Console.Write("Digite um número: ");
        // int n1 = int.Parse(Console.ReadLine());
        // Console.WriteLine("Positivo: " + (n1 > 0));
        // Console.WriteLine("Negativo: " + (n1 < 0));
        // Console.WriteLine("Zero: " + (n1 == 0));

        // 5 EXERCÍCIO
        // Console.Write("Digite a sua idade: ");
        // int n1 = int.Parse(Console.ReadLine());
        // Console.Write("Pode votar: " + (n1 >= 16));

        // NÍVEL DIFÍCIL

        // 1 EXERCÍCIO
        // Console.Write("Digite o usuário: ");
        // string user = Console.ReadLine();
        // Console.Write("Digite a senha: ");
        // string senha = Console.ReadLine();
        // Console.WriteLine("Login realizado: " + (user == "admin" && senha == "1234"));

        // 2 EXERCÍCIO
        // Console.Write("Digite o primeiro número: ");
        // int n1 = int.Parse(Console.ReadLine());
        // Console.Write("Digite o segundo número: ");
        // int n2 = int.Parse(Console.ReadLine());
        // Console.Write("Digite o terceiro número: ");
        // int n3 = int.Parse(Console.ReadLine());
        // Console.WriteLine("O primeiro número é maior: " + ((n1 > n2) && (n1 > n3)));
        // Console.WriteLine("O segundo número é maior: " + ((n2 > n1) && (n2 > n3)));
        // Console.WriteLine("O terceiro número é maior: " + ((n3 > n1) && (n3 > n2)));
        // Console.WriteLine("Os valores são iguais: " + ((n1 == n2) && (n1 == n3)));

        // 3 EXERCÍCIO (tá quebrado)
        // Console.Write("Digite seu salário: ");
        // decimal slr = decimal.Parse(Console.ReadLine());
        // decimal aumento10 = slr + (slr * 0.10m);
        // decimal aumento20 = slr + (slr * 0.20m);
        // Console.WriteLine("Salário com +10%: " + aumento10);
        // Console.WriteLine("Salário com +20%: " + aumento20);
        // Console.WriteLine("Recebe +10%: " + (slr > 2000m));
        // Console.WriteLine("Recebe +20%: " + (slr <= 2000m));

        // 4 EXERCÍCIO
        // Console.Write("Digite um ano: ");
        // int ano = int.Parse(Console.ReadLine());
        // Console.WriteLine("Ano bissexto simplificado: " + (ano % 4 == 0));

        // 5 EXERCÍCIO
        // Console.Write("Digite sua idade: ");
        // int idade = int.Parse(Console.ReadLine());
        // Console.Write("Tem convite? (true/false): ");
        // bool convite = bool.Parse(Console.ReadLine());
        // Console.WriteLine("Acesso: " + (idade >= 18 && convite));

    }
}
