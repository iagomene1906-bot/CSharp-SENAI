using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Sistema_de_cursos
{
    public abstract class Curso
    {
        public string nome { get; set; } = string.Empty;
        public int horas { get; set; }

        public Curso(string nomeConst, int horasConst)
        {
            nome = nomeConst;
            horas = horasConst;
        }

        public abstract double calcularPreco();

        public virtual void exibirResumo(){
            Console.WriteLine($"===== CURSO =====");
            Console.WriteLine($"\nCurso: {nome}\nCarga horária: {horas}\nPreço final: R${calcularPreco():f2}\n");
        }
    }
}