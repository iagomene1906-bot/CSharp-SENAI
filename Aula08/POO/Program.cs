namespace POO;

class Program
{
    static void Main(string[] args)
    {
        // Instânciando um objeto da Classe Carro
        Carro meuCarro = new Carro();

        // Definindo valores para os atributos

        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2022;

        // Chamando o método

        meuCarro.ExibirInformacoes();

        // Instânciando objeto Moto
        Moto minhaMoto = new Moto();
        minhaMoto.Marca = "Yamaha";
        minhaMoto.Ano = 2016;
        minhaMoto.TemPartidaEletrica = true;

        minhaMoto.ExibirDetalhes();
    }
}
