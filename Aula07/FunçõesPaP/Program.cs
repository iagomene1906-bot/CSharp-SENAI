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

        // FUNÇÕES MATEMÁTICAS

        // Valor absoluto -> se tiver um valor negativo transforma em positivo.
        // int valor = Math.Abs(-10); //10
        // Console.WriteLine(valor);

        // Potência
        // double potencia = Math.Pow(2,3); // Elevado.
        // Console.WriteLine(potencia);

        // Raiz quadrada
        // double raiz = Math.Sqrt(25); // Raiz quadrada de 25 = 5.
        // Console.WriteLine(raiz);

        // Arredondamento
        // double numero = Math.Round(3.6); // Arredonda para quatro.
        // Console.WriteLine(numero);

        // Números aleatorios
        // Random
        // Random random = new Random();
        // int numero = random.Next(1, 101); // Gera os números entre 1 e 100.
        // // ou int numero = random.Next(101); // Gera os números começando em 0.
        // Console.WriteLine(numero);

        // FUNÇÕES PARA STRING

        // Tamanho da string
        // string texto = "CSharp";
        // int tamanho = texto.Length;
        // Console.WriteLine(tamanho);

        // Substituir
        // string frase = "Olá, mundo!";
        // frase = frase.Replace("mundo","visitante!"); // Primeiro substitui a palavra que existe e depois, pelo que você quer trocar.
        // Console.WriteLine(frase);

        // Se existe dentro da frase
        // string frase = "Estou aprendendo C#";

        // if(frase.Contains("C#"))
        // {
        //     Console.WriteLine("A frase contém 'C#'");
        // }

        // // Para voltar verdadeiro ou falso: 

        // bool existe = frase.Contains("C#");
        // Console.WriteLine(existe);

        // FUNÇÕES DENTRO DE ARRAYS
        // int[] numeros = {1, 2, 4, 12, 8};
        // Array.Sort(numeros); // Ordenando valores
        // Console.WriteLine(string.Join(", ", numeros));


        // Inverter valores
        // Array.Reverse(numeros);
        // Console.WriteLine(string.Join(", ", numeros));


        // Adicionar outras informações

        // Simular adicionar valores em ARRAY
        // string[] nomes = {Ana, Bruno, Carlos};
        // string novoNome = "Pedro";
        // string[] novoArray = new string[nomes.Length + 1];

        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     novoArray[i] = nomes[i];
        // }

        // novoArray[novoArray.Length - 1] = novoNome;
        // nomes = novoArray;

        // foreach(string nome in nomes)
        // {
        //    Console.WriteLine(nome);
        // }

        // LIST

        // List<string> nomes = new List<string>();

        // // Adicionando nomes na lista.
        // nomes.Add("Ana");
        // nomes.Add("Bruno");
        // nomes.Add("Carlos");
        // nomes.Add("Pedro");

        // // Removendo nomes da lista.
        // nomes.Remove("Bruno");

        // foreach(string nome in nomes)
        // {
        //     Consol.WriteLine(nome);
        // }

        // // Acessar pela posição(indice)
        // Console.WriteLine(nomes[0]); // Ana

        // Ver o tamanho da lista
        // Console.WriteLine(nomes.Count); 

        // Console.Write("Digite o nome na busca: ");
        // string nomeDigitado = Console.ReadLine();

        // if(nomes.Contains(nomeDigitado)) // Motor de busca
        // {
        //     Console.WriteLine("Nome encontrado!");
        // }


        // Inserindo nome em posição específica
        // nomes.Insert(2, "Paula");

        // // Removendo nomes em posição específica
        // nomes.RemoveAt(3);

        // // Limpando a lista
        // nomes.Clear();

        // foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // Sistemas
        // List<string> produtos = new List<string>(); // Criando a lista

        // produtos.Add("Mouse");
        // produtos.Add("Teclado");
        // produtos.Add("Monitor"); // Adicionando 3 produtos

        // Console.Write("Digite o produto para remover: ");
        // string remover = Console.ReadLine();

        // if(produtos.Contains(remover))
        // {
        //     // Vai remover o produto
        //     produtos.Remove(remover);
        //     foreach(string produto in produtos)
        //     {
        //         Console.WriteLine(produto);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Produto não existe na lista.");
        // }

        // DESAFIO
        List<string> tarefas = new List<string>(); // Lista

        Console.WriteLine("\nDigite a opção que deseja\n1 - Adicionar tarefa na lista\n2 - Listar tarefas\n3 - Remover tarefa\n0 - Sair");
        int op = int.Parse(Console.ReadLine());

        
        do
        {
            switch(op){
                case 1:
                    Console.Write("Digite a tarefa: ");
                    tarefas.Add(Console.ReadLine());
                    break;

                case 2:
                    foreach(string tarefa in tarefas)
                    {
                        Console.WriteLine(tarefa);
                    }
                    break;

                case 3:
                    Console.Write("Digite a tarefa: ");
                    tarefas.Remove(Console.ReadLine());
                    break;

                case 0:
                    Console.WriteLine("Saindo da lista...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        while(op != 0);
    }
}
