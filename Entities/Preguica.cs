using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Entities
{
    class Preguica : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Ahhhhhh");
        }
        public override void Mover()
        {
            Console.WriteLine("Subir árvore");
        }
    }
}