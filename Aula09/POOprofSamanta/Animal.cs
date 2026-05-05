using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOprofSamanta
{
    public abstract class Animal
    {
        public string nome;

        public int idade;

        public string raca;

        public string cor;

        // Vitrual = O método será sobrescrito.
        public virtual void emitirSom(){
            Console.WriteLine($"O animal faz um som");
        }

        public void mostrarDados(){
            Console.WriteLine($"O animal {nome} tem {idade} anos!");
        }

        public abstract void comer();
    }
}