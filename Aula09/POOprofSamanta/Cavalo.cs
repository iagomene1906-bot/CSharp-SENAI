using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOprofSamanta
{
    public class Cavalo : Animal
    {
        public override void comer(){
            Console.WriteLine($"Comeu feno");
        }
        
        public override void emitirSom(){
            Console.WriteLine($"Iiirrrrí! 🐴");
        }
    }
}