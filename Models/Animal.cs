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
        public string Name { get; set; }

        public Animal()
        {
            Name = "Random";
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

    public class Dragon : Animal
    {
        public Dragon() : base()
        {
        }

        public Dragon(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} vole dans les airs.");
        }
    }

    public class Griffin : Animal
    {
        public Griffin() : base()
        {
        }

        public Griffin(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} s'envole .");
        }
    }
}

