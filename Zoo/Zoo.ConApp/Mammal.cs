
namespace Zoo.ConApp;

internal sealed class Mammal(string name) : Animal(name)
{
  public override string ToString()
    => new StringBuilder().Append(
                                  MammalTypeEmoji(this) +
                                  $"{Name}, ich wurde gesäugt."
                                  ).ToString();

  private string MammalTypeEmoji(Mammal mammal)
  {
    string mammalEmoji = " ";

    switch (mammal.Name)
    {
      case "Mensch": mammalEmoji = "🧘"; break;
      case "Pferd": mammalEmoji = "🐎"; break;
      case "Hase": mammalEmoji = "🐇"; break;
      case "Löwe": mammalEmoji = "🦁"; break;
      case "Katze": mammalEmoji = "🐈"; break;
      case "Hund": mammalEmoji = "🐕"; break;
      case "Kuh": mammalEmoji = "🐄"; break;
      case "Pudel": mammalEmoji = "🐩"; break;
      case "Blindenhund": mammalEmoji = "🦮"; break;
      case "Orangutan": mammalEmoji = "🦧"; break;
      case "Gorilla": mammalEmoji = "🦍"; break;
      case "Schimpanse": mammalEmoji = "🐒"; break;
      case "Giraffe": mammalEmoji = "🦒"; break;
      case "Zebra": mammalEmoji = "🦓"; break;
      case "Hirsch": mammalEmoji = "🦌"; break;
      case "Tiger": mammalEmoji = "🐅"; break;
      case "Bison": mammalEmoji = "🦬"; break;
      case "Nashorn": mammalEmoji = "🦏"; break;
      case "Schwein": mammalEmoji = "🐖"; break;
      case "Büffel": mammalEmoji = "🐃"; break;
      case "Nilpferd": mammalEmoji = "🦛"; break;
      case "Ochse": mammalEmoji = "🐂"; break;
      case "Leopard": mammalEmoji = "🐆"; break;
      case "Schaf": mammalEmoji = "🐑"; break;
      case "Elefant": mammalEmoji = "🐘"; break;
      case "Kamel": mammalEmoji = "🐫"; break;
      case "Dromedar": mammalEmoji = "🐪"; break;
      case "Ziege": mammalEmoji = "🐐"; break;
      case "Mammut": mammalEmoji = "🦣"; break;
      case "Lama": mammalEmoji = "🦙"; break;
      case "Kanguru": mammalEmoji = "🦘"; break;
      case "Stinktier": mammalEmoji = "🦨"; break;
      case "Dachs": mammalEmoji = "🦡"; break;
      case "Faultier": mammalEmoji = "🦥"; break;

      default: break;
    }

    return mammalEmoji + " ";
  }
}
