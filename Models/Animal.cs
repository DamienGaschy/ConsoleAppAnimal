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
        protected string Name { get; set; }

        //nom par défaut
        public Animal()
        {
            this.Name = "Clifford";
        }

        //move base
        public abstract void Move();

        //sleep base
        public void Sleep()
        {
            Console.WriteLine($"{Name} sleep");
        }

        //nom définit
        public Animal(string name)
        {
            this.Name = name;
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
            Console.WriteLine($"{Name} vole");
        }
    }
}

