namespace POOprofSamanta;

class Program
{
    static void Main(string[] args)
    {
        // ContaBancaria conta = new ContaBancaria();
        // conta.Sacar(200);
        // conta.MostrarSaldo();

        Cachorro c1 = new Cachorro();
        c1.nome = "Woody";
        c1.idade = 5;
        c1.raca = "Yorkshire";
        c1.cor = "Preto";
        c1.emitirSom();
        c1.mostrarDados();
        c1.comer();

        Console.WriteLine("--------------------------------");
        

        Gato g1 = new Gato();
        g1.nome = "Gato";
        g1.idade = 6;
        g1.raca = "de Botas";
        g1.cor = "Laranja";
        g1.emitirSom();
        g1.mostrarDados();
        g1.comer();

        Console.WriteLine("--------------------------------");
        
        Cavalo cl1 = new Cavalo();
        cl1.nome = "Pé de Pano";
        cl1.idade = 7;
        cl1.raca = "Shire";
        cl1.cor = "Preto";
        cl1.emitirSom();
        cl1.mostrarDados();
        cl1.comer();
    }
}
