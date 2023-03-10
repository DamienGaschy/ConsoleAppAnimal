using CSharpAnimal.Models.Animals;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Dragon();
        animal.Sleep();
        animal.Moove();

        Animal animal2 = new Griffin();
        animal2.Sleep();
        animal2.Moove();



        Dog Quipsi = new Dog("Loup", "Epic", 10 , 12);
        Dragon Smaug = new Dragon("Smaug", "Legendary", 99 , 2700);
        Griffin Peter = new Griffin("Peter Griffin", "Rare", 5 , 170);
        Dragon Altaria = new Dragon("Altaria", "Commun", 1 , 20);
        Dog Scott = new Dog("Scott", "Commun", 2 , 3);
        Dog Rocket = new Dog("Rocket", "Commun", 20 , 10);

        Animal[] liste = { Quipsi, Smaug, Peter, Altaria, Scott, Rocket };
        //var result = liste.Where(c => !c.Type.Contains("Rare"));

        //foreach (Animal animaux in result)
        //{
        //    Console.WriteLine(animaux.Name, animaux.Id);
        //}

        IEnumerable<Animal> listeAnimaux =
            from animaux in liste
            where animaux.Type == "Commun"
            select animaux;

        var sortedliste = listeAnimaux.OrderByDescending(c => c.Age).ToList();



        foreach (Animal animaux in sortedliste)
        {
            Console.WriteLine(animaux.name);
        }


        //Dog dog1 = new Dog("Loup");
        //Dog dog2 = new Dog("Enzo");
        //Dog dog3 = new Dog("Antoine");
        //Dog dog4 = new Dog("Raphaël");
        //Dog dog5 = new Dog("snow");
        //Dog[] dogs = { dog1, dog2, dog3, dog4, dog5 };
        //IEnumerable<Dog> differentThanSnow =
        //    from dog in dogs
        //    where dog.dogName != "snow"
        //    select dog;


        //Console.WriteLine("\nLes dogs sont : ");


        //foreach (Dog dog in differentThanSnow)
        //{
        //    Console.WriteLine(dog.dogName);
        //}


        Console.ReadLine();
    }
}