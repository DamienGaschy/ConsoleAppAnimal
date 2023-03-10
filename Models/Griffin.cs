using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpAnimal.Models.Animals
{
    class Griffin : Animal, IPilotage
    {
        public Griffin()
        {
            name = "Griffin";
        }
        public Griffin(string name, string type, int ID)
        {
            this.name = name;
            this.Type = type;
            this.Id = ID;
        }

        public override void Moove()
        {
            Console.WriteLine($"{name} s'envole");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{name} dors dans son nid");
        }
    }
}



