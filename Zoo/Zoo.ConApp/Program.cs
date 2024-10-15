namespace Zoo.ConApp;

internal class Program
{
  static void Main(string[ ] args)
  {
    Console.WriteLine("Zoo");

    Fish goldfisch = new Fish("Goldfisch");
    Fish zander = new Fish("Zander");
    Fish piranha = new Fish("Piranha");
    Bird canary = new Bird("Kanari");
    Bird chicken = new Bird("Huhn");
    Bird hawk = new Bird("Falke");
    Bird kiwi = new Bird("Kiwi");
    Bird eagle = new Bird("Adler");
    Mammal human = new Mammal("Mensch");
    Mammal dog = new Mammal("Hund");
    Mammal cat = new Mammal("Katze");
    Mammal lion = new Mammal("Löwe");
    Mammal horse = new Mammal("Pferd");
    Mammal rabbit = new Mammal("Hase");
    Mammal cow = new Mammal("Kuh");

    Set pets = new Set();
    pets.Add(goldfisch);
    pets.Add(canary);
    pets.Add(dog);    
    pets.Add(cat);
    pets.Add(rabbit);
    Console.WriteLine($"{pets.Count} Haustiere");
    Console.WriteLine(pets.ToString());

    Set farmedAnimals = new Set();
    farmedAnimals.Add(cow);
    farmedAnimals.Add(horse);
    farmedAnimals.Add(zander);
    farmedAnimals.Add(rabbit);
    farmedAnimals.Add(chicken);
    Console.WriteLine($"{farmedAnimals.Count} Nutztiere" );
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
     Bird penguin = new Bird("Pinguin",true);
     Console.WriteLine("Spezialistenaufgabe:");
     Console.WriteLine(penguin.ToString());
     
     Console.ReadLine();
  }
}
