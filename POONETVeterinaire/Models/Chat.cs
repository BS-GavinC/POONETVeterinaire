using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POONETVeterinaire.Models
{
    internal class Chat : Animal
    {
        public Chat(string name, int age, string robe) : base(name, age)
        {
            Robe = robe;
        }


        public string Robe { get; set; }


        public override string ToString()
        {
            return "Je suis un chat, " + base.ToString();
        }

    }
}
