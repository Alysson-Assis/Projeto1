using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Entities
{
    class Cachorro : Animal,Corredor
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Latido");
        }
        public void Correr()
        {
            Console.WriteLine("Correr");
        }
    }
}