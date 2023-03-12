using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Entities

{
    class Animal
    {
        public string Name { get; set; }
        public int Idade { get; set; }

        public virtual void EmitirSom()
        {
            Console.WriteLine("som desconhecido");
        }
      
      
        public virtual void Mover()
        {
            Console.WriteLine("movimento desconhecido");
        }
    }

}