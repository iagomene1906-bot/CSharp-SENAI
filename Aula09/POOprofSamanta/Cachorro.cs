using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOprofSamanta
{
    public class Cachorro : Animal
    {
        public override void comer(){
            Console.WriteLine($"Comeu Pedigree");
        }

        // override = Redefinir um método herdado.
        public override void emitirSom(){
            Console.WriteLine($"Au au!");
        }
    }
}