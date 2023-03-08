using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal.Models
{
    class Vehicule
    {
        public Vehicule(string name)
        {
            this.name = name;
        }

        public string name { get; set; }

        public virtual void embarquer()
        {
            Console.WriteLine("On embarque !");
        }
        public virtual void avancer()
        {
            Console.WriteLine("On avance !");
        }
        public virtual void reculer()
        {
            Console.WriteLine("On recule !");
        }
    }
}
