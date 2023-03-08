using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimal.Models
{
    public class Griffin : Animal
    {
        public Griffin()
        {
        }

        public Griffin(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} s'envole .");
        }
        public new void Sleep()
        {
            Console.WriteLine($"{Name} est endormi dans son nid.");
        }

    }
}
