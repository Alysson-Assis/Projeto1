using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Entities
{
    class Cavalo : Animal, Corredor
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Relinchar");
        }
        public void Correr()
        {
            Console.WriteLine("Correr");
        }
    }
}