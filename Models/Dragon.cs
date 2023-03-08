using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal.Models
{
    public class Dragon : Animal
    {
        public Dragon()
        {
        }

        public Dragon(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} vole dans les airs.");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{Name} est endormi sur son trésor.");
        }
    }
}
