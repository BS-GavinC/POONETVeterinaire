using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace POONETVeterinaire.Models
{
    internal class Chien : Animal
    {
        public Chien(string name, int age, string pedigree) : base(name, age)
        {
            Pedigree = pedigree;
        }

        public string Pedigree { get; set; }

    }
}
