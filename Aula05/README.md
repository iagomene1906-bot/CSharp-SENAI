# Aula - 05
Estruturas de Condicionais (if, else, switch case e operador ternário).

Atividade prática de Programação em C#:
Resolução de exercícios envolvendo estruturas condicionais (if, else, switch case e operador ternário). 
Os exercícios estão organizados em níveis (fácil, médio e difícil) para desenvolver o raciocínio lógico e a tomada de decisão em algoritmos.

---

## Material

[Estruturas Condicionais](https://sparkling-link-662.notion.site/Estruturas-Condicionais-35116837961280cfb558e1fcd72fd9dd)

[Lista de exercícios](https://sparkling-link-662.notion.site/Exerc-cios-Condicionais-34e1683796128091b664d6acdb0aa0ff)

---

## Exemplos

### if / else / else if

    Console.Write("Digite um número: ");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0){
        Console.WriteLine($"\n{num} é par");
    }
    else{
        Console.WriteLine($"\n{num} é impar");
    }

#### Ternário 

    string resultado = num % 2 == 0 ? "Par" : "Impar";
    Console.WriteLine(resultado);


### Switch case

    Console.WriteLine("Digite um de 1 a 3:");
    int num = int.Parse(Console.ReadLine());

    switch(num){
        case 1:
            Console.WriteLine("Você escolheu a opção 1.");
            break;
                
        case 2:
            Console.WriteLine("Você escolheu a opção 2.");
            break;

        case 3:
            Console.WriteLine("Você escolheu a opção 3.");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
        }