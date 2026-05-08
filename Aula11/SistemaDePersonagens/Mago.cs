using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDePersonagens
{
    public class Mago : Personagem
    {
        public Mago(string nomeConstrutor, int nivelConstrutor, string efeitoConstrutor) : base(nomeConstrutor, nivelConstrutor, efeitoConstrutor)
        {
            
        }

        public override int calcularPoder()
        {
            if(efeito == "buff")
            {
                return nivel * 10 + 40;
            }
            else
            {
                return nivel * 8 + 20;
            }
        }

        public override void exibirStatus()
        {
            Console.WriteLine("===== STATUS DO MAGO =====");
            
            Console.WriteLine($"\nNome: {nome}\nNivel: {nivel}\nPoder total dos ataques: {calcularPoder()}\n");
        }
    }
}