# Aula - 07
Estruturas de Funções e Arrays.

---

## Material

[Funções e Arrays](https://sparkling-link-662.notion.site/Fun-es-e-Arrays-352168379612809a941ada233b071627)

[Lista de exercícios](https://sparkling-link-662.notion.site/Atividade-Fun-es-Arrays-3521683796128022aacbc899bcc44bc6)

---

## Exemplos

### Função sem parâmetro e retorno

    static void MostrarMensagem(){
        Console.WriteLine("Olá mundo");
    }

    MostrarMensagem();

### Função com parâmetro

    static void Saudacao(string nome){
        Console.WriteLine($"Olá, {nome}");
    }

    Saudacao("Visitante!");

### Função com retorno

    static int Somar (int a, int b){
        int soma = a + b;
        return(soma);
    }

    Console.WriteLine(Somar(6, 7));

### Arrays

**Armazena vários valores do mesmo tipo em uma única variável.**

Criando a lista

    int[] numeros = new int[3];

Adicionando nas posições

    numeros[0] = 2;
    numeros[1] = 5;
    numeros[2] = 8;

Exibindo

    Console.WriteLine(numeros[2]);

<div/>

    Console.WriteLine(string.Join(", ", numeros));


### Números

Número positivo

    int valor = Math.Abs(-10);
    Console.WriteLine(valor);

Potência

    double potencia = Math.Pow(2,3); //2 ^ 3
    Console.WriteLine(potencia);

Raiz quadrada

    double raiz = Math.Sqrt(25);
    Console.WriteLine(raiz);

Arredondar

    double numero = Math.Round(3.6);
    Console.WriteLine(numero);

Randon (É necessária a importação)

    Random random = new Random();

<div/>

    int aleatorio = random.Next(1, 101);
    Console.WriteLine(aleatorio);

### Texto

Contar caracteres

    string texto = "Csharp";
    int tamanho = texto.Length;

    Console.WriteLine(tamanho);

Substituir texto

    string frase = "Ola Csharp";
    frase = frase.Replace("csharp", "mundo");

    Console.WriteLine(frase);

Achar texto

    string frase = "Estou aprendendo C#";
        
    if (frase.Contains("C#")){
            Console.WriteLine("A frase tem C#");
    }

### Arrays

Listar Array completo

    Console.WriteLine(string.Join(", ", numeros));

Ordenar

    int[] numeros = {1, 24, 5, 12, 15};
    Array.Sort(numeros);

    Console.WriteLine(string.Join(", ", numeros));

Reverter

    int[] numeros = {1, 24, 5, 12, 15};
    Array.Reverse(numeros);

    Console.WriteLine(string.Join(", ", numeros));

### List

### Adicionar elemento sem o List (Array)

    string[] nomes = { "Davizin", "Iago" };
    string novoNome = "Wesley";

    string[] novoArray = new string[nomes.Length + 1];

    for (int i = 0; i < nomes.Length; i++)
    {
        novoArray[i] = nomes[i];
    }

    novoArray[novoArray.Length - 1] = novoNome;
    nomes = novoArray;

    Console.WriteLine(string.Join(", ", nomes));

### Usando List

    List<string> nomes = new List<string>();

Adicionando nomes

    nomes.Add("Davi");
    nomes.Add("Iago");
    nomes.Add("Lucas");

    foreach(string nome in nomes){
        Console.WriteLine(nome);
    }

Removendo nomes

    nomes.Remove("Lucas");

    foreach(string nome in nomes){
        Console.WriteLine(nome);
    }

Imprimindo elemento

    Console.WriteLine(nomes[0]);

Contando tamanho da lista

    Console.WriteLine(nomes.Count);

Encontrando elemento

    if(nomes.Contains("Davi")){
        Console.WriteLine("Nome encontrado");
    }

Inserir na posição

    nomes.Insert(1, "Pedro");
    
    foreach(string nome in nomes){
        Console.WriteLine(nome);
    }

Remover Inserir na posição

    nomes.RemoveAt(1);

    foreach(string nome in nomes){
        Console.WriteLine(nome);
    }

Limpar lista

    nomes.Clear();