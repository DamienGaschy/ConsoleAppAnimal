using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimal.Models.Animals
{
    class Dragon : Animal, IPilotage
    {
        public Dragon()
        {
            name = "Smaug";
        }

        public Dragon(string name, string type, int ID)
        {
            this.name = name;
            this.Type = type;
            this.Id = ID;
        }
        public override void Moove()
        {
            Console.WriteLine($"{name} vole");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{name} dors sur son trésor");
        }s
    }
}
