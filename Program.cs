using System;
using ConsoleAppAnimal;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();

        //Création Animal en prennant un nom en paramètre
        Animal Chien = new Animal(name);

        //affiche {Name} + move
        Chien.Move();

        ////affiche {Name} + sleep
        Chien.Sleep();

        //Création Animal en prenant un nom par défaut
        Animal Chat = new Animal();

        //affiche {Name} + move
        Chat.Move();

        ////affiche {Name} + sleep
        Chat.Sleep();
    }
}