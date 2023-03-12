
using Projeto1.Entities;

namespace Projeto1.Service
{
    class Zoologico
    {
        public Animal[] jaulas;

        public Zoologico()
        {

            jaulas = new Animal[10];
        }
        public void AdicionarAnimal(Animal animal)
        {
            for (int i = 0; i < jaulas.Length; i++)
            {
                if (jaulas[i] == null)
                {
                    jaulas[i] = animal;
                    break;
                }
            }
        }
        public void EmitirSom(){
            foreach(Animal animal in jaulas){
                if(animal != null){
                    animal.EmitirSom();
                }
            }
        }
        public void FazerCorrer(){
            foreach(Animal animal in jaulas){
                if(animal is Corredor){
                    ((Corredor)animal).Correr();
                    
                    
                }
            }
        }
    }
}