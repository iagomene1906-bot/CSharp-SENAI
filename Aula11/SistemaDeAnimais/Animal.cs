using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeAnimais
{
    public abstract class Animal
    {
        public string nome { get; set; } = string.Empty;

        public Animal(string nomeConstrutor)
        {
            nome = nomeConstrutor;
        }

        public abstract string emitirSom();

        public abstract string tipoAlimentacao();

        public abstract void exibirAnimal();
    }
}