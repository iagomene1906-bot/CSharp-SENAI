using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDePersonagens
{
    public abstract class Personagem
    {
        public string nome { get; set; } = string.Empty;
        public int nivel { get; set; }
        public string efeito { get; set; } = string.Empty;

        public Personagem(string nomeConstrutor, int nivelConstrutor, string efeitoConstrutor)
        {
            nome = nomeConstrutor;
            nivel = nivelConstrutor;
            efeito = efeitoConstrutor;
        }

        public abstract int calcularPoder();

        public virtual void exibirStatus()
        {
            Console.WriteLine("===== STATUS =====");
            
            Console.WriteLine($"\nNome: {nome}\nNivel: {nivel}\nPoder total dos ataques: {calcularPoder()}\n");
        }
    }
}