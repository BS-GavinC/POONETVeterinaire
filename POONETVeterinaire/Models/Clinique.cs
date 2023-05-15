using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POONETVeterinaire.Models
{
    internal class Clinique
    {

        public Clinique()
        {

        }

        public Clinique(params Animal[] animalsToAdd)
        {
            this.Ajouter(animalsToAdd);
        }


        List<Animal> animals = new List<Animal>();

        public void Ajouter(params Animal[] animalsToAdd)
        {
            foreach (Animal animal in animalsToAdd)
            {
                if (!animals.Contains(animal))
                {
                    animals.Add(animal);    
                }
            }
        }

        public void Supprimer(params Animal[] animalsToRemove)
        {
            foreach (Animal animal in animalsToRemove)
            {
                if (animals.Contains(animal))
                {
                    animals.Remove(animal);
                }
            }

            
        }

        public void Afficher()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

    }
}
