namespace Zoo.ConApp;

internal class Program
{
  static void Main()
  {
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Zoo\n" + new String('-' , 20));

    Fish tropenfisch = new("Tropenfisch"); //    
    Fish zander = new("Zander");           //   
    Fish hai = new("Hai");                 //   

    Bird chicken = new("Huhn");        //  
    Bird canary = new("Kanari");       //  
    Bird eagle = new("Adler");         //  
    Bird hawk = new("Falke");          //  
    Bird kiwi = new("Kiwi");           //  

    Mammal rabbit = new("Hase");       //  
    Mammal human = new("Mensch");      //  
    Mammal horse = new("Pferd");       //  
    Mammal lion = new("Löwe");         //  
    Mammal cat = new("Katze");         //  
    Mammal dog = new("Hund");          //  
    Mammal cow = new("Kuh");           //  

    Set pets = new();
    pets.Add(tropenfisch);
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


    Fish wale = new("Wal");
    Mammal faultier = new("Faultier");

    Mammal oo1 = new("Hund");
    Mammal oo2 = new("Kuh");
    Mammal oo3 = new("Pudel");
    Mammal oo4 = new("Blindenhund");
    Mammal oo5 = new("Orangutan");
    Mammal oo6 = new("Gorilla");
    Mammal oo7 = new("Schimpanse");
    Mammal oo8 = new("Giraffe");
    Mammal oo9 = new("Zebra");
    Mammal o10 = new("Hirsch");
    Mammal o11 = new("Tiger");
    Mammal o12 = new("Bison");
    Mammal o13 = new("Nashorn");
    Mammal o14 = new("Schwein");
    Mammal o15 = new("Büffel");
    Mammal o16 = new("Nilpferd");
    Mammal o17 = new("Ochse");
    Mammal o18 = new("Leopard");
    Mammal o19 = new("Schaf");
    Mammal o20 = new("Elefant");
    Mammal o21 = new("Kamel");
    Mammal o22 = new("Dromedar");
    Mammal o23 = new("Ziege");
    Mammal o24 = new("Mammut");
    Mammal o25 = new("Lama");
    Mammal o26 = new("Kanguru");
    Mammal o27 = new("Stinktier");
    Mammal o28 = new("Dachs");
    Mammal o29 = new("Faultier");











    Console.WriteLine(
      oo1 + "\n" + 
      oo2 + "\n" + 
      oo3 + "\n" + 
      oo4 + "\n" + 
      oo5 + "\n" + 
      oo6 + "\n" + 
      oo7 + "\n" + 
      oo8 + "\n" + 
      oo9 + "\n" + 
      o10 + "\n" + 
      o11 + "\n" + 
      o12 + "\n" + 
      o13 + "\n" + 
      o14 + "\n" + 
      o15 + "\n" + 
      o16 + "\n" + 
      o17 + "\n" + 
      o18 + "\n" + 
      o19 + "\n" + 
      o20 + "\n" + 
      o21 + "\n" + 
      o22 + "\n" + 
      o23 + "\n" + 
      o24 + "\n" + 
      o25 + "\n" + 
      o26 + "\n" + 
      o27 + "\n" + 
      o28 + "\n" + 
      o29 + "\n"
      );
  }
}
