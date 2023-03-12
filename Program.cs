using System;
using System.Collections.Generic;
using Projeto1.Entities;
using Projeto1.Service;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Cachorro {Name = "Pipoca", Idade =5};
            Animal animal2 = new Cavalo{ Name = "Freedoom", Idade =8};
            Animal animal3 = new Preguica{ Name = "Speed", Idade = 12};

            Animal[] animais = {animal1, animal2, animal3};

            foreach(Animal animal in animais){

                animal.EmitirSom();
            }

            Console.WriteLine();
            Veterinario veterinario = new Veterinario();

            veterinario.Examinar(animal1);
            veterinario.Examinar(animal2);
            veterinario.Examinar(animal3);

            Console.WriteLine();
            Zoologico zoo = new Zoologico();

            zoo.AdicionarAnimal(animal2);
            zoo.AdicionarAnimal(animal1);
            zoo.AdicionarAnimal(animal3);
            zoo.AdicionarAnimal(animal2);
            zoo.AdicionarAnimal(animal1);
            zoo.AdicionarAnimal(animal3);
            zoo.AdicionarAnimal(animal1);
            zoo.AdicionarAnimal(animal2);
            zoo.AdicionarAnimal(animal2);
            zoo.AdicionarAnimal(animal3);

            zoo.EmitirSom();
            zoo.FazerCorrer();

        
        }
    }
}