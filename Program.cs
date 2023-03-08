using System;
using ConsoleAppAnimal.Models;

class Program
{
    static void Main(string[] args)
    {
        ////Entrer le nom sur la commande
        //string name = Console.ReadLine();

        //Création Animal en prennant un nom en paramètre
        Animal Chien = new Animal();

        //affiche {Name} + move
        Chien.Move();

        ////affiche {Name} + sleep
        Chien.Sleep();

        //Création Animal en prenant un nom par défaut
        Animal Chat = new Animal("Garfield");

        //affiche {Name} + move
        Chat.Move();

        //affiche {Name} + sleep
        Chat.Sleep();
    }
}