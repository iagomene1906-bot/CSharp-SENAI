using System.Security.Cryptography;

namespace Exercicios;

class Program
{
    static void Main(string[] args)
    {
        // NIVÉL FÁCIL

        // EXERCÍCIO 1
        // Console.Write("Informe a temperatura: ");
        // int temp = int.Parse(Console.ReadLine());


        // if (temp < 15)
        // {
        //     Console.WriteLine("Está frio.");

        //     if (temp < 0)
        //     {
        //         Console.WriteLine("Está muito frio.");
        //     }
        // }
        // else if (temp < 26)
        // {
        //     Console.WriteLine("Está agradavel.");
        // }
        // else
        // {
        //     Console.WriteLine("Está quente.");
        // }

        // EXERCÍCIO 2
        // Console.Write("Digite um número: ");
        // int n1 = int.Parse(Console.ReadLine());


        // if (n1 > 100)
        // {
        //     Console.WriteLine("O número digitado é maior do que 100.");
        // }
        // else if (n1 == 100)
        // {
        //     Console.WriteLine("O número digitado é 100");
        // }
        // else
        // {
        //     Console.WriteLine("O número digitado é menor do que 100.");
        // }

        // EXERCÍCIO 3
        // Console.Write("Digite o usuário: ");
        // string user = (Console.ReadLine());
        // Console.Write("Digite a senha: ");
        // string password = (Console.ReadLine());

        // if (user == "iago" && password == "pass123")
        // {
        //     Console.WriteLine("Acesso autorizado.");
        // }
        // else if (user == "iago" || password == "pass123")
        // {
        //     Console.WriteLine("Usuário ou senha inválidos.");
        // }
        // else
        // {
        //     Console.WriteLine("Usuário não encontrado.");
        // }

        // EXERCÍCIO 4
        // int n1 = 10;

        // Console.WriteLine(n1 < 0 ? "Número inválido." : "Número válido.");

        // EXERCÍCIO 5
        // Console.Write("Digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // Console.WriteLine(idade < 16 ? "Cadastro não permitido." : "Cadastro permitido.");

        //EXERCÍCIO 6
        // Console.WriteLine("Digite o número de um turno: \n1 = manhã \n2 = tarde \n3 = noite");
        // int turno = int.Parse(Console.ReadLine());

        // switch (turno)
        // {
        //     case 1:
        //         Console.WriteLine("Você escolheu o turno da manhã.");
        //         break;
        //     case 2:
        //         Console.WriteLine("Você escolheu o turno da tarde.");
        //         break;
        //     case 3:
        //         Console.WriteLine("Você escolheu o turno da noite.");
        //         break;
        //     default: 
        //         Console.WriteLine("Opção inválida.");
        //         break;
        // }

        //EXERCÍCIO 7
        // Console.WriteLine("O que deseja fazer? \n1 = Novo Jogo \n2 = Carregar jogo \nSair");
        // int turno = int.Parse(Console.ReadLine());

        // switch (turno)
        // {
        //     case 1:
        //         Console.WriteLine("Loading... novo jogo.");
        //         break;
        //     case 2:
        //         Console.WriteLine("Loading... carregar jogo.");
        //         break;
        //     case 3:
        //         Console.WriteLine("Loading... sair.");
        //         break;
        //     default: 
        //         Console.WriteLine("Opção inválida.");
        //         break;
        // }

        //NÍVEL MÉDIO

        //EXERCÍCIO 1
        // Console.Write("Classificador de idade \nDigite a sua idade para prosseguirmos: ");
        // int idade = int.Parse(Console.ReadLine());

        // if (idade <= 12)
        // {
        //     Console.WriteLine("Classificação: Criança.");
        // }
        // else if (idade <= 17){
        //     Console.WriteLine("Classificação: Adolescente.");
        // }
        // else
        // {
        //     Console.WriteLine("Classificação: Adulto.");
        // }

        // EXERCÍCIO 2
        // int n1 = 20;
        // int n2 = 10;

        // Console.WriteLine(n1 > n2 ? "O primeiro valor é maior do que o segundo valor digitado." : "O segundo valor é maior do que o primeiro valor digitado.");

        //EXERCÍCIO 3
        // Console.Write("Digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // Console.Write("Possui ingresso? (true/false) ");
        // bool ingresso = bool.Parse(Console.ReadLine());

        // if (idade >= 18 || ingresso == true)
        // {
        //     Console.WriteLine("Acesso liberado");
        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado");
        // }

        //EXERCÍCIO 4
        // int n1 = 8;

        // if (n1 > 10 || n1 < 0)
        // {
        //     Console.WriteLine("Valor inválido.");
        // }
        // else
        // {
        //     Console.WriteLine("Valor válido.");
        // }

        // EXERCÍCIO 5
        // Console.Write("Digite o valor: ");
        // decimal valor = decimal.Parse(Console.ReadLine());
        // Console.Write("Informe a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if (idade < 18)
        // {
        //     Console.WriteLine($"Sem desconto. \nValor: {valor}");
        // }
        // else if (idade >= 18 && idade < 60)
        // {
        //     Console.WriteLine($"Desconto de 10%. \nValor: {valor * 0.9m}");
        // }
        // else
        // {
        //     Console.WriteLine($"Desconto de 20%. \nValor: {valor * 0.8m}");
        // }

        // EXERCÍCIO 6
        // decimal cV = 200m;

        // Console.WriteLine(cV >= 200m ? $"15% de desconto: {cV * 0.85m}" : $"5% de desconto: {cV * 0.95m}" );
    
        // EXERCÍCIO 7
        // Console.Write("Digite o primeiro valor: ");
        // double v1 = double.Parse(Console.ReadLine());
        // Console.Write("Digite o segundo valor: ");
        // double v2 = double.Parse(Console.ReadLine());

        // Console.Write("Digite a operação desejada (+, -, * ou /): ");
        // string op = Console.ReadLine();

        // switch (op)
        // {
        //     case "+":
        //         Console.WriteLine("\nResultado da operação: " + (v1 + v2));
        //         break;
        //     case "-":
        //         Console.WriteLine("\nResultado da operação: " + (v1 - v2));
        //         break;
        //     case "*":
        //         Console.WriteLine("\nResultado da operação: " + (v1 * v2));
        //         break;
        //     case "/":
        //         Console.WriteLine("\nResultado da operação: " + (v1 / v2));
        //         break;
        //     default:
        //         Console.WriteLine("\nOpção inválida.");
        //         break;
        // }

        // EXERCÍCIO 8
        // Console.Write("Digite um número de 1 a 7: ");
        // int op = Console.ReadLine();

        // switch (op)
        // {   
        //     case 1:
        //     case 7:
        //         Console.WriteLine("Fim de semana.");
        //         break;
        //     case 2:
        //     case 3:
        //     case 4:
        //     case 5:
        //     case 6:
        //         Console.WriteLine("Dia útil.");
        //         break;
        //     default:
        //         Console.WriteLine("Dia inválido.");
        //         break;
        // }

        // EXERCÍCIO 9 
        // Console.WriteLine("Digite o seu plano de internet para descobrir a banda: \nB - Para plano básico \nI - Para intermediário \nP - Para premium\n");
        // char op = char.Parse(Console.ReadLine().ToUpper());

        // switch (op)
        // {
        //     case 'B':
        //         Console.WriteLine("\nSeu plano tem uma banda de 10MB.");
        //         break;
        //     case 'I':
        //         Console.WriteLine("\nSeu plano tem uma banda de 50MB.");
        //         break;
        //     case 'P':
        //         Console.WriteLine("\nSeu plano tem uma banda de 100MB.");
        //         break;
        //      default:
        //          Console.WriteLine("Opção inválida.");
        //          break;
        // }

        // NÍVEL DIFÍCIL

        //
    }
}
