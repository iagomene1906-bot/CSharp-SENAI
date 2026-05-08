using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVeiculos
{
    public abstract class Veiculo
    {
        public string modelo { get; set; } = string.Empty;
        public int ano { get; set; }

        public Veiculo(string modeloConstrutor, int anoConstrutor)
        {
            modelo = modeloConstrutor;
            ano = anoConstrutor;
        }

        public abstract int calcularRevisao();

        public void exibirRevisao()
        {
            Console.WriteLine("===== REVISÃO =====");
            Console.WriteLine($"\nO veículo: {modelo}\nAno: {ano}\nTem o custo de revisão: R${calcularRevisao():f2}\n");
        }
    }
}