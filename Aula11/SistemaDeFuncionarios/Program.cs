namespace SistemaDeFuncionarios;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Gerente("Iago", 6700),
            new Vendedor("Davi", 1600),
        };

        Console.Clear();

        foreach (var funcionario in funcionarios)
        {
            funcionario.exibirSalario();   
        }
    }
}
