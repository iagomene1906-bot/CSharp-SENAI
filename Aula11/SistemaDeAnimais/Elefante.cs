using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeAnimais
{
    public class Elefante : Animal
    {
        public Elefante(string nomeConstrutor) : base(nomeConstrutor)
        {
            
        }

        public override string emitirSom()
        {
            return "Fuumm uuuuh!🐘";
        }

        public override string tipoAlimentacao()
        {
            return "Herbívoro🌿";
        }

        public override void exibirAnimal()
        {
            Console.WriteLine($"===== ELEFANTE =====");
            Console.WriteLine($"\n{emitirSom()}\nNome: {nome}\nTipo de alimentação: {tipoAlimentacao()}\n");
        }
    }
}