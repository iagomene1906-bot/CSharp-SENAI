using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFuncionarios
{
    public abstract class Funcionario
    {
        public string nome { get; set; } = string.Empty;
        public double salarioBase { get; set; }

        public Funcionario(string nomeConstrutor, double salarioConstrutor)
        {
            nome = nomeConstrutor;
            salarioBase = salarioConstrutor;
        }

        public abstract double calcularSalario();

        public void exibirSalario()
        {
            Console.WriteLine("===== SALÁRIO DO FUNCIONÁRIO =====");
            
            Console.WriteLine($"\nFuncionário(a): {nome}\nSalário: {calcularSalario():f2}\n");
        }
    }
}