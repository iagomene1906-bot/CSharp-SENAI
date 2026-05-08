using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeAnimais
{
    public class Leao : Animal
    {
        public Leao(string nomeConstrutor) : base(nomeConstrutor)
        {
            
        }

        public override string emitirSom()
        {
            return "Roaaaaaar!🦁";
        }

        public override string tipoAlimentacao()
        {
            return "Carnívoro🥩";
        }

        public override void exibirAnimal()
        {
            Console.WriteLine($"===== LEÃO =====");
            Console.WriteLine($"\n{emitirSom()}\nNome: {nome}\nTipo de alimentação: {tipoAlimentacao()}\n");
        }
    }
}