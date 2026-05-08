namespace SistemaDePersonagens;

class Program
{
    static void Main(string[] args)
    {
        List<Personagem> personagens = new List<Personagem>
        {
            new Mago("Harry Potter", 8, ""),
            new Mago("Patolino", 20, "buff"),
            new Guerreiro("Aquiles", 8, ""),
        };

        Console.Clear();

        foreach (var personagem in personagens)
        {
            personagem.exibirStatus();
        }
    }
}
