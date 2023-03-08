using System;
using ConsoleAppAnimal;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();

        //Création Animal
        Animal Chien = new Animal(name);

        //affiche {Name} + move
        Chien.Move();

        ////affiche {Name} + sleep
        Chien.Sleep();
    }
}