namespace FunçõesPaP;

class Program
{
    static void Main(string[] args)
    {
        /*
            ESTRUTURA DE UMA FUNÇÃO

            tipoDeRetorno NomeDaFunção(parametros)
            {
                    comandos da função
            }

            função = repite um bloco de comandos várias vezes.
            static = essa função é usada dentro deste arquivo.
            void = não tem retorno.
        */

        // FUNÇÃO SEM PARAMETROS E SEM RETORNO

        // static void MostrarMensagem()
        // {
        //     Console.WriteLine("Olá! Boa tarde!");
        // }
        // MostrarMensagem(); // Chamando a função.



        // FUNÇÃO COM PARAMETROS
        // parametro -> string nome.

        // static void Saudacao(string nome)
        // {
        //     Console.WriteLine($"Olá, {nome}!");
        // }

        // Saudacao("visitante");


        // FUNÇÃO COM RETORNO
        // Parametros a, b.
        // Retorno é a soma.

        // static int Somar(int a, int b) 
        // {
        //     // int soma = a + b;
        //     return a + b;
        // }

        // int resultado = Somar(6, 7);
        // Console.WriteLine(resultado);



        // ARRAYS
        // Armazena vários valores do mesmo tipo em uma única variável.
        // Array é como uma lista de informações.
        // Array precisa ter os tipos definidos
        // Posições do array = Indice e começam do 0. (Exemplo: Posição 3 = Indice 4)
        // Join = Junta cada um dos números e separa por vírgula.
        // Array ele entendo como um objeto.

        // int[] numeros = new int[5]; // Array vázio mas com um limite de 5 posições.
        
        // Console.WriteLine(numeros);

        // numeros[0] = 2;
        // numeros[1] = 5;
        // numeros[2] = 8;
        // numeros[3] = 15;
        // numeros[4] = 20;
        
        // Console.WriteLine(numeros);
        // // Solução alternativa para mostrar o array (impresso em string)
        // Console.WriteLine(string.Join(", ", numeros));



        // nomes.Length - Length = função de tamanho do array.
        // string[] nomes = {"Penelope", "Davi", "Iago"};

        // // Percorre com for.
        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }

        // // Percorre com foreach
        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }



        // FUNÇÃO + ARRAY
        // static double calcularMedia(double[] notas)
        // {
        //     double soma = 0;

        //     for(int i = 0; i < notas.Length; i++)
        //     {
        //         soma += notas[i];
        //         //soma = soma + nota[posição]
        //     }

        //     return soma / notas.Length;
        // }

        // double[] notasAluno = [8.0, 7.5, 9.0, 6.5];
        // double media = calcularMedia(notasAluno);
        // Console.WriteLine($"Média final: {media}");



        // Outro exemplo
        // int[] numeros = new int[5];
        // int soma = 0;

        // for(int i = 0; i < numeros.Legth; i++)
        // {
        //     Console.Write($"Digite para mim o {i + 1}° número: ");
        //     numeros[i] = int.Parse(Console.ReadLine());

        //     soma += numeros[i];
        // }

        // Console.WriteLine(string.Join(", ", numeros));
        // Console.WriteLine(string.Join($"A soma dos números dos números é: {soma}"));



        // DESAFIO 

        // static string vAprovado(double nota)
        // {
        //     if(notas >= 7)
        //     {
        //         return "Aprovado";
        //     }
        //     else
        //     {
        //         return "Reprovado!";
        //     }
        // }

        // string[] alunos = new string[3];
        // double[] notas = new double[3];

        // for(int i = 0; i < alunos.Legth; i++)
        // {
        //     Console.Write("Digite o nome do aluno: ");
        //     alunos[i] = Console.ReadLine();
        //     Console.Write("Digite a nota do aluno: ");
        //     notas[i] = double.Parse(Console.ReadLine());
        // }
        // // alunos = ["Samuel", "Lucas", "Iago"]
        // // notas = [7.0, 10.0, 9,5]
        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.WriteLine($"{alunos[i]} - Nota: {notas[i]} - Situcação: {vAprovado}");
        // }
    }
}
