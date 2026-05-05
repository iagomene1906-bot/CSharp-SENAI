using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOprofSamanta
{
    public class Gato : Animal
    {
        public override void comer(){
            Console.WriteLine($"Comeu Whiskas");
        }

        public override void emitirSom(){
            Console.WriteLine($"Miau!");
        }
    }
}