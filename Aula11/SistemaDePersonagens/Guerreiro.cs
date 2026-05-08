using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDePersonagens
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nomeConstrutor, int nivelConstrutor, string efeitoConstrutor) : base(nomeConstrutor, nivelConstrutor, efeitoConstrutor)
        {
            
        }

        public override int calcularPoder()
        {
            if(efeito == "buff")
            {
                return nivel * 15;
            }
            else
            {
                return nivel * 10;
            }
            
        }

        public override void exibirStatus()
        {
            Console.WriteLine("===== STATUS DO GUERREIRO =====");
            
            Console.WriteLine($"\nNome: {nome}\nNivel: {nivel}\nPoder total dos ataques: {calcularPoder()}\n");
        }
    }
}