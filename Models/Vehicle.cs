﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimal.Models.Animals
{

    class Vehicule : IPilotage
    {
        public void Moove()
        {
            Console.WriteLine(" Moove !");
        }
    }
}
