using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto1.Entities;

namespace Projeto1.Service
{
    class Veterinario
    {
        public void Examinar(Animal animal){
            animal.EmitirSom();
        }
    }
}