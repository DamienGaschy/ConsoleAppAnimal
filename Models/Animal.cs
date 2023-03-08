using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppAnimal.Models
{
    public abstract class Animal
    {
        public string Name { get; private set; }

        public Animal()
        {
            Name = "Clifford";
        }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Move();

        public void Sleep()
        {
            Console.WriteLine($"{Name} est endormi.");
        }
    }
}

