using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFuncionarios
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nomeConstrutor, double salarioConstrutor) : base(nomeConstrutor, salarioConstrutor)
        {
        
        }

        public override double calcularSalario()
        {
            return salarioBase * 1.20;
        }
    }
}