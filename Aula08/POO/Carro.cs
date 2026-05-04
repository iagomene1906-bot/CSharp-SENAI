using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    // Classe derivada (subclasse) -> Herda informações de veículo.
    public class Carro : Veiculo
    {
        // Atributos da Classe

        // public string Marca;

        public string Modelo;

        // public int Ano;

        // Metódos (ações que a classe pode realizar)

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}