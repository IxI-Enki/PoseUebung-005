
namespace Zoo.ConApp;

internal sealed class Mammal(string name) : Animal(name)
{
  public override string ToString()
    => new StringBuilder().Append($"{MammalTypeEmoji(this)} {Name}, ich wurde gesäugt.").ToString();

  private string MammalTypeEmoji(Mammal mammal)
  {
    return mammal.Name switch
    {
      "Blindenhund" => "🦮",
      "Schimpanse" => "🐒",
      "Orangutan" => "🦧",
      "Stinktier" => "🦨",
      "Nilpferd" => "🦛",
      "Faultier" => "🦥",
      "Dromedar" => "🐪",
      "Gorilla" => "🦍",
      "Giraffe" => "🦒",
      "Elefant" => "🐘",
      "Leopard" => "🐆",
      "Kanguru" => "🦘",
      "Nashorn" => "🦏",
      "Schwein" => "🐖",
      "Mensch" => "🧘",
      "Hirsch" => "🦌",
      "Mammut" => "🦣",
      "Büffel" => "🐃",
      "Kamel" => "🐫",
      "Ziege" => "🐐",
      "Pferd" => "🐎",
      "Katze" => "🐈",
      "Pudel" => "🐩",
      "Zebra" => "🦓",
      "Tiger" => "🐅",
      "Bison" => "🦬",
      "Ochse" => "🐂",
      "Schaf" => "🐑",
      "Dachs" => "🦡",
      "Lama" => "🦙",
      "Hase" => "🐇",
      "Löwe" => "🦁",
      "Hund" => "🐕",
      "Kuh" => "🐄",
      _ => " ",
    };
  }
}
