using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal.Models
{
    public class Animal
    {
        private string Name { get; set; }

        public Animal()
        {
            this.Name = "Clifford";
        }

        public void Move()
        {
            Console.WriteLine($"{Name} move");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} sleep");
        }

        public Animal(string name)
        {
            this.Name = name;
        }
    }
}

