using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal
{
    public class Animal
    {
        private string Name { get; set; }

        public Animal(string name) 
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} move");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} sleep");
        }
    }
}

