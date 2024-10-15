namespace Zoo.ConApp;

internal class Program
{
  static void Main()
  {
    Console.WriteLine("Zoo");

    Fish goldfisch = new("Goldfisch");
    Fish piranha = new("Piranha");
    Fish zander = new("Zander");

    Bird chicken = new("Huhn");
    Bird canary = new("Kanari");
    Bird eagle = new("Adler");
    Bird hawk = new("Falke");
    Bird kiwi = new("Kiwi");

    Mammal rabbit = new("Hase");
    Mammal human = new("Mensch");
    Mammal horse = new("Pferd");
    Mammal lion = new("Löwe");
    Mammal cat = new("Katze");
    Mammal dog = new("Hund");
    Mammal cow = new("Kuh");

    Set pets = new();
    pets.Add(goldfisch);
    pets.Add(canary);
    pets.Add(dog);
    pets.Add(cat);
    pets.Add(rabbit);
    Console.WriteLine($"{pets.Count} Haustiere");
    Console.WriteLine(pets.ToString());

    Set farmedAnimals = new();
    farmedAnimals.Add(cow);
    farmedAnimals.Add(horse);
    farmedAnimals.Add(zander);
    farmedAnimals.Add(rabbit);
    farmedAnimals.Add(chicken);
    Console.WriteLine($"{farmedAnimals.Count} Nutztiere");
    Console.WriteLine(farmedAnimals.ToString());

    Set farmedPets = pets * farmedAnimals;
    Console.WriteLine($"{farmedPets.Count} Nutztiere zugleich Haustiere");
    Console.WriteLine(farmedPets.ToString());

    Set companionAnimals = pets + farmedAnimals;
    Console.WriteLine($"{companionAnimals.Count} zahme Tier");
    Console.WriteLine(companionAnimals.ToString());

    Set uneatableAnimals = pets - farmedAnimals;
    Console.WriteLine($"{uneatableAnimals.Count} nicht essbare Haustiere");
    Console.WriteLine(uneatableAnimals.ToString());

    // Spezialistenaufgabe: Zum Testen folgende Zeilen aktiv setzen.
    Bird penguin = new("Pinguin" , true);
    Console.WriteLine("Spezialistenaufgabe:");
    Console.WriteLine(penguin.ToString());

    Console.ReadLine();
  }
}
