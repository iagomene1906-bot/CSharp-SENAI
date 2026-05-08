namespace SistemaDeAnimais;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animais = new List<Animal>
        {
          new Leao("Alex"),
          new Elefante("Dumbo"),  
        };

        Console.Clear();

        foreach (var animal in animais)
        {
            animal.exibirAnimal();
        }
    }
}
