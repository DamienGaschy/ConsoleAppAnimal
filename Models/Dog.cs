using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAnimal.Models.Animals;

namespace CSharpAnimal.Models.Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, string type, int ID, int age)
        {
            this.name = name;
            this.Type = type;
            this.Id = ID;
            this.Age = age;
        }
    }
}