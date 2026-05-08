using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVeiculos
{
    public class Moto : Veiculo
    {
        public Moto(string modeloConstrutor, int anoConstrutor) : base(modeloConstrutor, anoConstrutor)
        {
        }

        public override int calcularRevisao(){
            return 300;
        }
    }
}