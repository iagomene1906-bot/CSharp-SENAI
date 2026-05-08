namespace SistemaDeVeiculos;

class Program
{
    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>{
            new Carro("320i", 2011),
            new Moto("R6", 2016),
        };

        Console.Clear();

        foreach(var veiculo in veiculos){
            veiculo.exibirRevisao();
        }
    }
}
