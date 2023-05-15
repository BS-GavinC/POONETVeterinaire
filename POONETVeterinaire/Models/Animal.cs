using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POONETVeterinaire.Models
{
    internal abstract class Animal
    {

       
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public string Sexe { get; set; }

        public override string ToString()
        {
            return $"Je m'appelle {Name}, et j'ai {Age} ans.";
        }

    }
}
