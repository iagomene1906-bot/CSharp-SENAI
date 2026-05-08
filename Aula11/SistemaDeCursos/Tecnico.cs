using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Sistema_de_cursos
{
    public class Tecnico : Curso
    {
        public Tecnico(string nomeConst, int horasConst) : base(nomeConst, horasConst)
        {
        }

        public override double calcularPreco(){
            return horas * 20;
        }

        public override void exibirResumo(){
            Console.WriteLine($"===== CURSO TÉCNICO =====");
            Console.WriteLine($"\nCurso: {nome}\nCarga horária: {horas}\nPreço final: R${calcularPreco():f2}\n");
        }
    }
}